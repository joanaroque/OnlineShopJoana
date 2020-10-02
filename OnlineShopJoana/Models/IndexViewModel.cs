using Microsoft.AspNetCore.Identity;

using System.Collections.Generic;

namespace OnlineShopJoana.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }


        public IList<UserLoginInfo> Logins { get; set; }



        public bool TwoFactor { get; set; }


        public bool BrowserRemembered { get; set; }
    }
}
