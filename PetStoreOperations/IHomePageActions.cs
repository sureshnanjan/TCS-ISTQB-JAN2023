using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreOperations
{
    public interface IHomePageActions
    {
        bool verifyLogo();
        bool verifySearchOptions();
        bool verifySideMenuItems();
        bool verifyMainMenuItems();
        bool verifyHeaderFooterItems();
    }
}
