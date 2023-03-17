namespace Ranequ.Messaging.Model
{
    public enum EventCode
    {
        /// <summary>
        ///     Initiates processing request.
        /// </summary>
        Received = 100,

        /// <summary>
        ///     This event indicates that the request has been routed to a particular service.
        /// </summary>
        Routed = 120,

        /// <summary>
        ///     Respond with this event id to indicate that the processing request has been accepted.
        /// </summary>
        Confirmed = 130,

        /// <summary>
        ///     Respond with this event id to indicate that the processing request has not been accepted.
        /// </summary>
        NotAccepted = 140,

        /// <summary>
        ///     The delivery service responds with this event to indicate that the content has been delivered.
        /// </summary>
        ContentDelivered = 180
    }
}