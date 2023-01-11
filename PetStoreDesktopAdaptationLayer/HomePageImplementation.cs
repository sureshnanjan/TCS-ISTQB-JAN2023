using PetStoreOperations;
using System.Diagnostics;
using Appium;

namespace PetStoreDesktopAdaptationLayer
{
    public class HomePageImplementation : IHomePageActions
    {
        public HomePageImplementation() {
            Process.Start(new ProcessStartInfo(@"C:\Users\nanja\source\repos\TCS-ISTQB-JAN2023\PetStoreDesktopApplication\bin\Debug\PetStoreDesktopApplication.exe"));
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
