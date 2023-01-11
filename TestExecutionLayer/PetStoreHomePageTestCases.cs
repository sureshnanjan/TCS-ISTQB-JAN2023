using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PetStoreOperations;
using PetStoreWebAdaptationLayer;

namespace TestExecutionLayer
{
    [TestClass]
    public class PetStoreHomePageTestCases
    {
        [TestMethod]
        public void PetStoreHomePageLogoPlacementTest() {
            // Arrange 
            IHomePageActions pageActions = new HomePageImplementation();
            bool result = pageActions.verifyLogo();
            Assert.IsTrue(result);


        
        }
        [TestMethod]
        
        public void PetStoreSearchButtonTest() {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void PetStoreMenuItemsTest() {
            throw new NotImplementedException();
        }
        
        [TestMethod]
        public void PetStoreLeftSideListingTest() {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void PetStoreHeaderFooterTest() {
            throw new NotImplementedException();
        }
    }
}
