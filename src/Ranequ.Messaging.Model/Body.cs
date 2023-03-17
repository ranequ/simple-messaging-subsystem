using Newtonsoft.Json;

namespace Ranequ.Messaging.Model
{
    /// <summary>
    ///     This class defines the message body.
    /// </summary>
    [JsonObject(Id = "body")]
    public class Body
    {
        /// <summary>
        ///     Gets or Sets Event
        /// </summary>
        [JsonProperty("code")]
        public Event Event { get; set; }

        /// <summary>
        ///     Gets or Sets Content
        /// </summary>
        [JsonProperty("content")]
        public Content Content { get; set; }
    }
}