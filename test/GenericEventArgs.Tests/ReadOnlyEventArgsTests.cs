using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericEventArgs.Tests
{
    /// <summary>
    /// Tests for ReadOnlyEventArgs
    /// </summary>
    [TestClass]
    public class ReadOnlyEventArgsTests
    {        
        /// <summary>
        /// Check if both reference and value types are assigned correctly
        /// </summary>
        [TestMethod]
        public void ReadOnlyEventArgs_ReadOnlyEventArgs()
        {
            var valueType = new TestValueType();
            var valueTypeEventArgs = new ReadOnlyEventArgs<TestValueType>(valueType);
            var valueTest = Equals(valueType, valueTypeEventArgs.Data);

            var referenceType = new TestReferenceType();
            var referenceTypeEventArgs = new ReadOnlyEventArgs<TestReferenceType>(referenceType);
            var referenceTest = ReferenceEquals(referenceType, referenceTypeEventArgs.Data);

            Assert.IsTrue(valueTest && referenceTest);
        }
    }
}
