using Newtonsoft.Json;

namespace Ranequ.Messaging.Model
{
    /// <summary>
    ///     This class contains event descriptions 
    /// </summary>
    [JsonObject(Id = "event")]
    public class Event
    {
        /// <summary>
        ///     Gets or Sets EventCode
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }
    }
}