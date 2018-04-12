using System;
using System.Collections.Generic;
using System.Text;

namespace GenericEventArgs
{
    /// <summary>
    /// Base implementation for CancelEventArgs
    /// </summary>
    public interface ICancelEventArgs
    {
        #region Properties

        /// <summary>
        /// Indicates whether event is cancelled
        /// </summary>
        bool Cancel { get; set; }

        #endregion
    }
}
