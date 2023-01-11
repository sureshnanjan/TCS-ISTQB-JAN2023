using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestExecutionLayer
{
    [TestClass]
    public class BinarySearchTestCases
    {
        [TestMethod]
        public void testforExistingItems()
        {
            // Arrange
            int[] items = new int[] { 1, 2, 4, 5, 6, 7, 8 };
            int itemToSearch = 2;
            int expectedResult = 1;
            // Act
            int actualresult = MyBinarySearcher.DoBinarySearch(items,itemToSearch);
            // Assert
            Assert.AreEqual(expectedResult, actualresult);
        }

        [TestMethod]
        public void testforNonExistingItem() {
            // Arrange
            int[] items = new int[] { 1, 2, 4, 5, 6, 7, 8 };
            int itemToSearch = 12;
            int expectedResult = -1;
            // Act
            int actualresult = MyBinarySearcher.DoBinarySearch(items, itemToSearch);
            // Assert
            Assert.AreEqual(expectedResult, actualresult);
        }
        [TestMethod]
        public void testforInvalidInputs() { }
    }
}
