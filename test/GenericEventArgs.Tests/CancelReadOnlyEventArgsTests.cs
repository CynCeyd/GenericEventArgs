using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericEventArgs.Tests
{
    /// <summary>
    /// Tests for  CancelReadOnlyEventArgs
    /// </summary>
    [TestClass]
    public class CancelReadOnlyEventArgsTests
    {
        /// <summary>
        /// Check if Cancel property is assigned properly
        /// </summary>
        [TestMethod]
        public void CancelReadOnlyEventArgs_CancelReadOnlyEventArgs()
        {
            var valueType = new TestValueType();
            var valueTypeEventArgs = new CancelReadOnlyEventArgs<TestValueType>(valueType);

            var valueTestFalse = valueTypeEventArgs.Cancel;
            valueTypeEventArgs.Cancel = true;
            var valueTestTrue = valueTypeEventArgs.Cancel;

            var referenceType = new TestReferenceType();
            var referenceTypeEventArgs = new CancelReadOnlyEventArgs<TestReferenceType>(referenceType);

            var referenceTestFalse = referenceTypeEventArgs.Cancel;
            referenceTypeEventArgs.Cancel = true;
            var referenceTestTrue = referenceTypeEventArgs.Cancel;

            Assert.IsTrue(!valueTestFalse && valueTestTrue && !referenceTestFalse && referenceTestTrue);
        }
    }
}
