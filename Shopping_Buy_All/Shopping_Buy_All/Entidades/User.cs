using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }

        public User()
        {

        }

        public User(string userName, string password)
        {
            this.userName = userName.ToLower();
            this.password = password;
        }
    }
}
