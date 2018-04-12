using System;
using System.Collections.Generic;
using System.Text;

namespace GenericEventArgs
{
    /// <summary>
    /// Generic implementation of cancelable EventArgs carrying a custom payload
    /// </summary>
    /// <typeparam name="TEventData">Type of payload</typeparam>
    /// <inheritdoc cref="EventArgs{TEventData}"/>
    /// <inheritdoc cref="ICancelEventArgs"/>
    public class CancelEventArgs<TEventData> : EventArgs<TEventData>, ICancelEventArgs
    {
        #region Properties

        public bool Cancel { get; set; }

        #endregion

        /// <summary>
        /// Instantiate generic EventArgs with custom payload
        /// </summary>
        /// <param name="data">Event data payload</param>
        public CancelEventArgs(TEventData data) : base(data)
        {
            // no content required
        }
    }
}
