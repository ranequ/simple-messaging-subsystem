using Newtonsoft.Json;

namespace Ranequ.Messaging.Model
{
    /// <summary>
    ///     This class defines the message structure, that encompasses all the details.
    /// </summary>
    [JsonObject(Id = "message")]
    public class Message
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public Message()
        {
            Body = new Body();
            Head = new Head();
        }

        /// <summary>
        ///     Gets or Sets Head
        /// </summary>
        [JsonProperty("head")]
        public Head Head { get; set; }

        /// <summary>
        ///     Gets or Sets Body
        /// </summary>
        [JsonProperty("body")]
        public Body Body { get; set; }
    }
}
