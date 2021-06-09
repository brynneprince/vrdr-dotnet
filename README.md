[![Build Status](https://travis-ci.org/nightingaleproject/vrdr-dotnet.svg?branch=master)](https://travis-ci.org/nightingaleproject/vrdr-dotnet)
[![Nuget](https://img.shields.io/nuget/v/VRDR?label=VRDR%20%28nuget%29)](https://www.nuget.org/packages/VRDR)
[![Nuget](https://img.shields.io/nuget/v/VRDR.Messaging?label=VRDR.Messaging%20%28nuget%29)](https://www.nuget.org/packages/VRDR.Messaging)

# vrdr-dotnet
This repository includes .NET (C#) code for

- Producing and consuming the Vital Records Death Reporting (VRDR) Health Level 7 (HL7) Fast Healthcare Interoperability Resources (FHIR) standard. [Click here to view the FHIR Implementation Guide](http://hl7.org/fhir/us/vrdr/2019May/).
- Producing and consuming FHIR messages for the exchange of VRDR documents.
- Support for converting VRDR FHIR records to and from the Inter-Jurisdictional Exchange (IJE) Mortality format, as well as companion microservice for performing conversions.

## Versions
<table class="versionTable" border="3">
<tbody>
<tr>
<td style="text-align: center;"><strong>VRDR IG</strong></td>
<td style="text-align: center;"><strong>FHIR</strong></td>
<td style="text-align: center;"><strong>Version</strong></td>
<td style="text-align: center;"><strong>VRDR.dotnet</strong></td>
<td style="text-align: center;"><strong>VRDR.Messaging</strong></td>
</tr>
<tr>
<td style="text-align: center;">STU1</td>
<td style="text-align: center;">R4</td>
<td style="text-align: center;">V3.1.0</td>
<td style="text-align: center;"><a href="https://www.nuget.org/packages/VRDR/3.1.0">nuget</a> <a href="https://github.com/nightingaleproject/vrdr-dotnet/releases/tag/v3.1.0"> github</a></td>
<td style="text-align: center;"><a href="https://www.nuget.org/packages/VRDR.Messaging/3.1.0">nuget</a> <a href="https://github.com/nightingaleproject/vital_records_fhir_messaging/releases/download/v3.1.0/fhir_messaging_for_nvss.pdf"> github</a></td>
</tr>
</tbody>
</table>

## Requirements

- Development & CLI Requirements
  - This repository is built using .NET Core 3.1, download [here](https://dotnet.microsoft.com/download)
  - You can also use .NET Core 2.1, see VRDR.CLI section below for instructions
- Library Usage
  - The VRDR or VRDR.Messaging libraries target .NET Standard 2.0
  - To check wether your .NET version supports a release, refer to (this)[https://docs.microsoft.com/en-us/dotnet/standard/net-standard#net-implementation-support] .NET matrix. First, note whether you are using .NET Core or .NET Framework - see (here)[https://docs.microsoft.com/en-us/archive/msdn-magazine/2017/september/net-standard-demystifying-net-core-and-net-standard] for distinctions between the .NET implementation options  Once you’ve determined your .NET implementation type and version, for example if you are using .NET Framework 4.6.1, refer to the matrix to verify whether your .NET implementation supports the targeted .NET Standard version. By looking at the matrix, you can see the .NET Framework 4.6.1 supports .NET Standard 2.0 so the tool would be supported.

## Project Organization

### VRDR
This directory contains a FHIR Death Record library for consuming and producing VRDR FHIR. This library also includes support for converting to and from the Inter-Jurisdictional Exchange (IJE) Mortality format.

For API documentation, [click here](VRDR/DeathRecord.md).

#### Usage

This package is published on NuGet, so including it is as easy as:
```xml
<ItemGroup>
  ...
  <PackageReference Include="VRDR" Version="3.1.0-RC2" />
  ...
</ItemGroup>
```

You can also include a locally downloaded copy of the library instead of the NuGet version by referencing `DeathRecord.csproj` in your project configuration, for example (taken from VRDR.CLI):
```xml
<Project Sdk="Microsoft.NET.Sdk">
  ...
  <ItemGroup>
    <ProjectReference Include="..\VRDR\DeathRecord.csproj" />
    ...
  </ItemGroup>
</Project>
```

#### Producing Example
The following snippet is a quick example of producing a from-scratch FHIR VRDR record using this library, and then printing it out as a JSON string. For a complete example, [click here](https://github.com/nightingaleproject/csharp-fhir-death-record/blob/master/VRDR.CLI/Program.cs#L23).
```cs
using VRDR;

DeathRecord deathRecord = new DeathRecord();

// Set Death Record ID
deathRecord.Identifier = "42";

// Add Decedent Given Names
string[] givenNames = { "First", "Middle" };
deathRecord.GivenNames = givenNames;

// Add Decedent Last Name
deathRecord.FamilyName = "Last";

// Cause of Death Part I, Line a
deathRecord.COD1A = "Rupture of myocardium";

// Cause of Death Part I Interval, Line a
deathRecord.INTERVAL1A = "Minutes";

// Cause of Death Part I Code, Line a
Dictionary<string, string> exampleCode = new Dictionary<string, string>();
exampleCode.Add("code", "I21.0");
exampleCode.Add("system", "ICD-10");
exampleCode.Add("display", "Acute transmural myocardial infarction of anterior wall");
deathRecord.CODE1A = exampleCode;

// Add PregnancyStatus
Dictionary<string, string> code = new Dictionary<string, string>();
code.Add("code", "PHC1260");
code.Add("system", "urn:oid:2.16.840.1.114222.4.5.274");
code.Add("display", "Not pregnant within past year");
deathRecord.PregnancyStatus = code;

// Add ExaminerContacted
deathRecord.ExaminerContacted = false;

// Add DateOfDeath
deathRecord.DateOfDeath = "2018-07-10T10:04:00+00:00";

// Print record as a JSON string
Console.WriteLine(deathRecord.ToJSON());
```

#### Consuming Example
An example of consuming a VRDR FHIR document (in XML format) using this library, and printing some details from it:
```cs
using VRDR;

// Read in FHIR Death Record XML file as a string
string xml = File.ReadAllText("./example_vrdr_fhir_record.xml");

// Construct a new DeathRecord object from the FHIR VRDR XML string
DeathRecord deathRecord = new DeathRecord(xml);

// Print out some details from the record
Console.WriteLine($"Decedent's Last Name: {deathRecord.FamilyName}");

Console.WriteLine($"Date/Time of Death: {deathRecord.DateOfDeath}");

Console.WriteLine($"Cause of Death Part I, Line a: {deathRecord.COD1A}");
Console.WriteLine($"Cause of Death Part I Interval, Line a: {deathRecord.INTERVAL1A}");
Console.WriteLine($"Cause of Death Part I Code, Line a: {String.Join(", ", deathRecord.CODE1A.Select(x => x.Key + "=" + x.Value).ToArray())}");
```

#### FHIR VRDR record to/from IJE Mortality format
An example of converting a VRDR FHIR Death Record to an IJE string:
```cs
using VRDR;

// Read in FHIR Death Record XML file as a string
string xml = File.ReadAllText("./example_vrdr_fhir_record.xml");

// Construct a new DeathRecord object from the string
DeathRecord deathRecord = new DeathRecord(xml);

// Create an IJEMortality instance from the DeathRecord
IJEMortality ije = new IJEMortality(deathRecord);

// Print out the corresponding IJE version of the DeathRecord
string ijeString = ije.ToString(); // Converts DeathRecord to IJE
Console.WriteLine(ijeString);
```

An example of converting an IJE string to a VRDR FHIR Death Record:
```cs
using VRDR;

// Construct a new IJEMortality instance from an IJE string
IJEMortality ije = new IJEMortality("..."); // This will convert the IJE string to a DeathRecord

// Grab the corresponding FHIR DeathRecord
DeathRecord deathRecord = ije.ToDeathRecord();

// Print out the converted FHIR DeathRecord as a JSON string
Console.WriteLine(deathRecord.ToJSON());
```

#### Return Coding
An example of producing a `CodingResponseMessage` for handling the returned message from NCHS containing coded causes. For a complete example, [click here](https://github.com/nightingaleproject/vrdr-dotnet/blob/master/doc/Messaging.md#return-coding).

```cs
using VRDR;
// Create an empty coding response message
CodingResponseMessage message = new CodingResponseMessage("https://example.org/jurisdiction/endpoint");

// Assign the business identifiers
message.CertificateNumber = "...";
message.StateAuxiliaryIdentifier = "...";
message.NCHSIdentifier = "...";

// Create the cause of death coding
message.UnderlyingCauseOfDeath = <icd code>;

// Assign the record axis codes
var recordAxisCodes = new List<string>();
recordAxisCodes.Add(<icd code>);
recordAxisCodes.Add(<icd code>);
recordAxisCodes.Add(<icd code>);
recordAxisCodes.Add(<icd code>);
message.CauseOfDeathRecordAxis = recordAxisCodes;

// Assign the entity axis codes
var builder = new CauseOfDeathEntityAxisBuilder();
// for each entity axis codes
...
builder.Add(<lineNumber>, <positionInLine>, <icd code>);
...
// end loop
message.CauseOfDeathEntityAxis = builder.ToCauseOfDeathEntityAxis();

// Create a JSON representation of the coding response message
string jsonMessage = message.ToJSON();
```
Note that the `CauseCodes` class from previous versions is now obsolete, use the `CodingResponseMessage` described above instead.

### VRDR.Messaging

This directory contains classes to create and parse FHIR messages used for Vital Records Death Reporting.

#### Usage

This package is published on NuGet, so including it is as easy as:
```xml
<ItemGroup>
  ...
  <PackageReference Include="VRDR.Messaging" Version="3.1.0-RC2" />
  ...
</ItemGroup>
```

Note that the VRDR.Messaging package automatically includes the VRDR package, a project file should not reference both.

You can also include a locally downloaded copy of the library instead of the NuGet version by referencing `VRDRMessaging.csproj` in your project configuration, for example:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  ...
  <ItemGroup>
    <ProjectReference Include="..\VRDR.Messaging\VRDRMessaging.csproj" />
    ...
  </ItemGroup>
</Project>
```

Use of the VRDR.Messaging library to support various message exchange scenarios is described in [`doc/Messaging.md`](doc/Messaging.md).

### VRDR.Tests
This directory contains unit and functional tests for the VRDR library.

#### Usage
The tests are automatically run by this repositories Travis CI config, but can be run locally by executing the following command in the root project directory:
```bash
dotnet test
```

### VRDR.CLI
This directory contains a sample command line interface app that uses the VRDR library to do a few different things.

NOTE: If you would like to run the CLI using .NET core 2.1, append `--framework netcoreapp2.1` to the end of all the example commands below

#### Example Usages
```bash
# Builds a fake death record and print out the record as FHIR XML and JSON
dotnet run

# Read in the FHIR XML or JSON death record and print out as IJE
dotnet run 2ije 1.xml

# Read in the IJE death record and print out as FHIR XML
dotnet run ije2xml 1.MOR

# Read in the IJE death record and print out as FHIR JSON
dotnet run ije2json 1.MOR

# Read in the FHIR XML death record and print out as FHIR JSON
dotnet run xml2json 1.xml

# Read in the FHIR JSON death record and print out as FHIR XML
dotnet run json2xml 1.json

# Read in the FHIR JSON death record, completely disassemble then reassemble, and print as FHIR JSON
dotnet run json2json 1.json

# Read in the FHIR XML death record, completely disassemble then reassemble, and print as FHIR XML
dotnet run xml2xml 1.xml

# Read in the given FHIR xml (being permissive) and print out the same; useful for doing validation diffs
dotnet run checkXml 1.xml

# Read in the given FHIR json (being permissive) and print out the same; useful for doing validation diffs
dotnet run checkJson 1.json

# Read in and parse an IJE death record and print out the values for every (supported) field
dotnet run ije 1.MOR
```

### VRDR.HTTP
This directory contains a deployable microservice that exposes endpoints for conversion of IJE flat files to DeathRecord JSON or XML, and vice versa.

The current available endpoints to `POST` to are:
```
http://<server>:8080/xml   <- For requesting a record as FHIR in XML format
http://<server>:8080/json  <- For requesting a record as FHIR in JSON format
http://<server>:8080/ije   <- For requesting a record as IJE
```

Include a `Content-Type` header indicating what format the record is represented as in the body of the message (e.g. `application/fhir+json`, `application/fhir+xml`, or `application/ije`.).

#### Running

To build a Dockerized version from scratch (from source), you can do so by running (inside the project root directory):

```
dotnet publish
docker build -t vrdr-microservice -f ./VRDR.HTTP/Dockerfile .
docker run -p 8080:8080 vrdr-microservice
```

If you prefer not to use Docker, you can run it from the root project directory using [.NET Core](https://dotnet.microsoft.com/download):

```
dotnet run
```

The service will be listening locally at `http://localhost:8080`.

#### Publishing a Version

To create a new release of VRDR on NuGet, bump the version of the VRDR and VRDR.Messaging listed in the [Directory.Build.props](Directory.Build.props) file. Whenever a commit is merged into the master branch that changes the Directory.Build.props file, [Github Actions](.github/workflows/publish.yml) will automatically build and publish a new version of the package based on the value specified.

## License

Copyright 2018, 2019, 2020 The MITRE Corporation

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at

```
http://www.apache.org/licenses/LICENSE-2.0
```

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.

### Contact Information

For questions or comments about vrdr-dotnet, please send email to

    cdc-nvss-feedback-list@lists.mitre.org
