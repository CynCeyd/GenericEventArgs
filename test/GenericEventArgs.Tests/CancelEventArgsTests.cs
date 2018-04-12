using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEventArgs.Tests
{
    /// <summary>
    /// Tests for CancelEventArgs
    /// </summary>
    [TestClass]
    public class CancelEventArgsTests
    {
        /// <summary>
        /// Check if Cancel property is assigned properly
        /// </summary>
        [TestMethod]
        public void CancelEventArgs_CancelEventArgs()
        {
            var valueType = new TestValueType();
            var valueTypeEventArgs = new CancelEventArgs<TestValueType>(valueType);

            var valueTestFalse = valueTypeEventArgs.Cancel;
            valueTypeEventArgs.Cancel = true;
            var valueTestTrue = valueTypeEventArgs.Cancel;

            var referenceType = new TestReferenceType();
            var referenceTypeEventArgs = new CancelEventArgs<TestReferenceType>(referenceType);

            var referenceTestFalse = referenceTypeEventArgs.Cancel;
            referenceTypeEventArgs.Cancel = true;
            var referenceTestTrue = referenceTypeEventArgs.Cancel;

            Assert.IsTrue(!valueTestFalse && valueTestTrue && !referenceTestFalse && referenceTestTrue);
        }
    }
}
