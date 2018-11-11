using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RjmLogin
{

    class User
    {
        private static string username = "admin";
        private static string password = "123456";

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string PassWrod
        {

            get { return password; }
            set { password = value; }
        }
    }
}
