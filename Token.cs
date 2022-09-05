using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice
{
    public class Token
    {
        public static string token { get; set; }
        public static void setToken (string t) { token = t; }
        public static string getToken () { return token; }
    }
}
