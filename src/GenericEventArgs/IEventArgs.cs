using System;
using System.Collections.Generic;
using System.Text;

namespace GenericEventArgs
{
    /// <summary>
    /// Base implementation of generic EventArgs
    /// </summary>
    /// <typeparam name="TEventData">Type of data payload</typeparam>
    public interface IEventArgs<TEventData>
    {
        #region Properties

        /// <summary>
        /// Data payload of event
        /// </summary>
        TEventData Data { get; set; }

        #endregion
    }
}
