using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_Clone.Services
{
    public static class UserSession
    {
        public static LoginResponse? CurrentUser { get; set; }
        public static bool IsLoggedIn => CurrentUser != null;
    }
}
