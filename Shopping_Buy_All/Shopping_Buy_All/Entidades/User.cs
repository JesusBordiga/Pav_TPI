using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; } = true;
        public DateTime DateLogin { get; set; } = DateTime.Now;


        public User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }
    }
}
