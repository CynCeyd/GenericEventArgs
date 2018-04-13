using System;
using System.Collections.Generic;
using System.Text;

namespace GenericEventArgs
{
    /// <summary>
    /// Generic implementation of EventArgs carrying a custom payload
    /// </summary>
    /// <typeparam name="TEventData">Type of payload</typeparam>
    /// <inheritdoc cref="IReadOnlyEventArgs{TEventData}"/>
    public class ReadOnlyEventArgs<TEventData> : EventArgs, IReadOnlyEventArgs<TEventData>
    {
        #region Properties

        public TEventData Data { get; protected set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Instantiate generic EventArgs with custom payload
        /// </summary>
        /// <param name="data">Event data payload</param>
        public ReadOnlyEventArgs(TEventData data)
        {
            Data = data;
        }

        #endregion

    }
}
