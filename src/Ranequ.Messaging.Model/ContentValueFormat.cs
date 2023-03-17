namespace Ranequ.Messaging.Model
{
    /// <summary>
    ///     Defines the possible content value formats
    /// </summary>
    public enum ContentValueFormat
    {
        /// <summary>
        ///     Indicates that the content value is presented as xml string.
        /// </summary>
        Xml,

        /// <summary>
        ///     Indicates that the content value is presented as json string.
        /// </summary>
        Json,

        /// <summary>
        ///     Indicates that the content value is presented as human readable text string.
        /// </summary>
        Text,

        /// <summary>
        ///     Indicates that the content value is presented as base 64 encoded string.
        /// </summary>
        Base64
    }
}