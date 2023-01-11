using PetStoreOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PetStoreWebAdaptationLayer
{
    public class HomePageImplementation : IHomePageActions
    {
        private IWebDriver _driver;
        public HomePageImplementation()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://petstore.octoperf.com/actions/Catalog.action";
        }
        public bool verifyHeaderFooterItems()
        {
            throw new System.NotImplementedException();
        }

        public bool verifyLogo()
        {
            throw new System.NotImplementedException();
        }

        public bool verifyMainMenuItems()
        {
            throw new System.NotImplementedException();
        }

        public bool verifySearchOptions()
        {
            throw new System.NotImplementedException();
        }

        public bool verifySideMenuItems()
        {
            throw new System.NotImplementedException();
        }
    }
}
