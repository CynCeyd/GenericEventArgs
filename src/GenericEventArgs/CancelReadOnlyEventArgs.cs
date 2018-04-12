using System;
using System.Collections.Generic;
using System.Text;

namespace GenericEventArgs
{
    /// <summary>
    /// Generic implementation of cancelable read-only EventArgs carrying a custom payload
    /// </summary>
    /// <typeparam name="TEventData">Type of payload</typeparam>
    /// <inheritdoc cref="ReadOnlyEventArgs{TEventData}"/>
    /// <inheritdoc cref="ICancelEventArgs"/>
    public class CancelReadOnlyEventArgs<TEventData> : ReadOnlyEventArgs<TEventData>, ICancelEventArgs
    {
        #region Properties

        public bool Cancel { get; set; }

        #endregion

        /// <summary>
        /// Instantiate generic read-only EventArgs with custom payload
        /// </summary>
        /// <param name="data">Event data payload</param>
        public CancelReadOnlyEventArgs(TEventData data) : base(data)
        {
            // no content required
        }
    }
}
