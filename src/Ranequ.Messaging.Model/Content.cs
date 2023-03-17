using Newtonsoft.Json;

namespace Ranequ.Messaging.Model
{
    /// <summary>
    ///     This class defines the message content with the necessary information how to deserialize it.
    /// </summary>
    [JsonObject(Id = "content")]
    public class Content
    {
        /// <summary>
        ///     Gets or Sets Value
        /// </summary>
        [JsonProperty("value")]
        public object Value { get; set; }

        /// <summary>
        ///     Gets or Sets Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Gets or Sets TypeShort
        /// </summary>
        [JsonProperty("typeShort")]
        public string TypeShort { get; set; }
    }
}