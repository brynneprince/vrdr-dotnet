using Hl7.Fhir.Model;

namespace VRDR
{
    /// <summary>Class <c>AckMessage</c> supports the acknowledgment of other messages.</summary>
    public class AckMessage : BaseMessage
    {
        /// <summary>Constructor that creates an acknowledgement for the specified message.</summary>
        /// <param name="messageToAck">the message to create an acknowledgement for.</param>
        /// <param name="source">the endpoint identifier that the ack message will be sent from.</param>
        public AckMessage(BaseMessage messageToAck, string source = "http://nchs.cdc.gov/vrdr_submission") : this(messageToAck.MessageId, messageToAck.MessageSource, source)
        {
        }

        /// <summary>
        /// Construct an AckMessage from a FHIR Bundle.
        /// </summary>
        /// <param name="messageBundle">a FHIR Bundle that will be used to initialize the AckMessage</param>
        /// <returns></returns>
        public AckMessage(Bundle messageBundle) : base(messageBundle)
        {
            // no payload for Ack message
        }

        /// <summary>Constructor that creates an acknowledgement for the specified message.</summary>
        /// <param name="messageId">the id of the message to create an acknowledgement for.</param>
        /// <param name="destination">the endpoint identifier that the ack message will be sent to.</param>
        /// <param name="source">the endpoint identifier that the ack message will be sent from.</param>
        public AckMessage(string messageId, string destination, string source = "http://nchs.cdc.gov/vrdr_submission") : base("vrdr_acknowledgement")
        {
            Header.Source.Endpoint = source;
            this.MessageDestination = destination;
            MessageHeader.ResponseComponent resp = new MessageHeader.ResponseComponent();
            resp.Identifier = messageId;
            resp.Code = MessageHeader.ResponseType.Ok;
            Header.Response = resp;
        }

        /// <summary>The id of the message that is being acknowledged by this message</summary>
        /// <value>the message id.</value>
        public string AckedMessageId
        {
            get
            {
                return Header.Response.Identifier;
            }
            set
            {
                Header.Response.Identifier = value;
            }
        }

    }
}