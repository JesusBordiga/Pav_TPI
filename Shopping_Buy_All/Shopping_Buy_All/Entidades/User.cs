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
        public bool Active { get; set; } = true;
        public DateTime DateLogin { get; set; } = DateTime.Now;


        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
