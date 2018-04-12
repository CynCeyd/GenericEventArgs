using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericEventArgs.Tests
{
    /// <summary>
    /// Tests for EventArgs
    /// </summary>
    [TestClass]
    public class EventArgsTests
    {
        /// <summary>
        /// Check if both reference and value types are assigned and modified correctly
        /// </summary>
        [TestMethod]
        public void EventArgs_EventArgs()
        {
            var valueType = new TestValueType();
            var valueTypeEventArgs = new EventArgs<TestValueType>(valueType);
            var valueTest = Equals(valueType, valueTypeEventArgs.Data);

            var referenceType = new TestReferenceType();
            var referenceTypeEventArgs = new EventArgs<TestReferenceType>(referenceType);
            var referenceTest = ReferenceEquals(referenceType, referenceTypeEventArgs.Data);

            referenceTypeEventArgs.Data = null;

            var nullTest = ReferenceEquals(null, referenceTypeEventArgs.Data);

            Assert.IsTrue(valueTest && referenceTest && nullTest);
        }
    }
}
