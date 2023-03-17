using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ranequ.Messaging.Model
{
    /// <summary>
    ///     This class represents the message head, that contains all the meta data related to the message.
    /// </summary>
    [JsonObject(Id = "head")]
    public class Head
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public Head()
        {
            Created = DateTime.UtcNow;
            Properties = new Dictionary<string, object>();
        }

        /// <summary>
        ///     Gets or Sets Version
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        ///     Gets or Sets SourceSys
        /// </summary>
        /// <remarks>
        ///     This filed indicates the source system name.
        /// </remarks>
        [JsonProperty("sourceSys")]
        public string SourceSys { get; set; }

        /// <summary>
        ///     Gets or Sets SourceSysId
        /// </summary>
        /// <remarks>
        ///     This filed indicates the source system identifier.
        /// </remarks>
        [JsonProperty("sourceSysId")]
        public Guid SourceSysId { get; set; }

        /// <summary>
        ///     Gets or Sets SourceApp
        /// </summary>
        /// <remarks>
        ///     This filed indicates the source application name.
        /// </remarks>
        [JsonProperty("sourceApp")]
        public string SourceApp { get; set; }

        /// <summary>
        ///     Gets or Sets SourceAppId
        /// </summary>
        /// <remarks>
        ///     This filed indicates the source application identifier.
        /// </remarks>
        [JsonProperty("sourceAppId")]
        public Guid SourceAppId { get; set; }

        /// <summary>
        ///     Gets or Sets message create date time.
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        ///     Gets or Sets the message content value format
        /// </summary>
        [JsonProperty("format")]
        public ContentValueFormat Format { get; set; }

        /// <summary>
        ///     Gets the message property bag.
        /// </summary>
        [JsonProperty("Properties")]
        public IDictionary<string, object> Properties { get; }
    }
}