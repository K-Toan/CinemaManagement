using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1735_Group6_A2.DTL
{
    public static class AppSettings
    {
        public static bool IsLoggedIn { get; set; } = false;
        public static string ConnectionString { get; set; }
        public static string AdminUsername { get; set; }
        public static string AdminPassword { get; set; }
    }
}
