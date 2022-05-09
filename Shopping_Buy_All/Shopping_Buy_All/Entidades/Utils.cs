using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Shopping_Buy_All.Entidades
{
    public static class Utils
    {
        public static byte[] UserToSHA256(string username, string password)
        {
            string toHash = username + ":" + password;
            byte[] bytes = Encoding.UTF8.GetBytes(toHash);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            return hash;
        }
    }
}
