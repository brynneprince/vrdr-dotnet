# Submit messages to the NVSS API; takes as arguments the jurisdiction to submit for (e.g., MA) and the files
# to send (must be valid FHIR messages)

require 'oauth2'
require 'active_support/time'
require 'securerandom'
require 'time'
require 'json'
require 'parallel'

jurisdiction = ARGV.shift
if jurisdiction.nil? || !jurisdiction.match(/^[A-Z][A-Z]$/)
  puts "You must provide the jurisdiction code (e.g., MA) as the first argument"
  exit
end

if ARGV.length < 1
  puts "Please provide files to submit"
  exit
end

client_id = File.read('clientid.txt')
client_secret = File.read('clientsecret.txt')
username = File.read('username.txt')
password = File.read('password.txt')

# Load all the files into memory first
files = []
ARGV.each do |filename|
  files << { filename: filename, message: File.read(filename) }
end

# Request the token using the OAuth client
client = OAuth2::Client.new(client_id,
                            client_secret,
                            site: 'https://apigw.cdc.gov/',
                            token_url: '/auth/oauth/v2/token')

token = client.password.get_token(username, password)

# Submit the files in chunks of 20
failures = []
Parallel.each(files.each_slice(20)) do |slice|

  output = "Sending files:\n"
  slice.each { |s| output += "  #{s[:filename]}\n" }

  # Build the package
  url = "/OSELS/NCHS/NVSSFHIRAPI/#{jurisdiction}/Bundles"
  messages = slice.map { |s| JSON.parse(s[:message]) }
  message_entries = messages.map { |message| { id: SecureRandom.uuid, request: { method: 'POST', url: url }, resource: message } }
  submission = { resourceType: 'Bundle', type: 'batch', id: SecureRandom.uuid, timestamp: Time.now.iso8601, entry: message_entries }

  body = submission.to_json

  begin
    response = token.post("/OSELS/NCHS/NVSSFHIRAPI/#{jurisdiction}/Bundles",
                          headers: { 'Content-Type' => 'application/json' },
                          body: body)
    output += "Server response for files #{slice.first[:filename]}-#{slice.last[:filename]}: #{response.status}\n"
    JSON.parse(response.body)['entry'].each do |entry|
      output += "  Record response: #{entry['response']['status']}\n"
    end
  rescue => e
    output += "Failed to send files in slice #{slice.first[:filename]}-#{slice.last[:filename]}\n"
    output += e.backtrace
    output += "\n"
    failures += slice
  ensure
    # We've collected up the output so that different parallel processes are less likely to step on each other's output
    puts output
  end
end

if failures.size > 0
  puts "Failed to send the following #{failures.size} records:"
  failures.each { |f| puts "  #{f[:filename]}\n" }
end
