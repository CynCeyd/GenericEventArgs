using System;
using System.Collections.Generic;
using System.Text;

namespace GenericEventArgs
{
    /// <summary>
    /// Generic implementation of EventArgs carrying a custom payload
    /// </summary>
    /// <typeparam name="TEventData">Type of payload</typeparam>
    /// <inheritdoc cref="IEventArgs{TEventData}"/>
    public class EventArgs<TEventData> : IEventArgs<TEventData>
    {
        #region Properties
        
        public TEventData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Instantiate generic EventArgs with custom payload
        /// </summary>
        /// <param name="data">Event data payload</param>
        public EventArgs(TEventData data)
        {
            Data = data;
        }

        #endregion

    }
}
