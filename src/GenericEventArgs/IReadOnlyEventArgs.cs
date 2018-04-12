using System;
using System.Collections.Generic;
using System.Text;

namespace GenericEventArgs
{
    /// <summary>
    /// Base implementation of read-only generic EventArgs
    /// </summary>
    /// <typeparam name="TEventData">Type of data payload</typeparam>
    public interface IReadOnlyEventArgs<out TEventData>
    {
        #region Properties

        /// <summary>
        /// Data payload of event
        /// </summary>
        TEventData Data { get; }

        #endregion
    }
}
