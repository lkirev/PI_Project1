using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace PI_Project
{
    public static class MyHash
    {
        private static String sSourceData { get; set; }
        private static byte[] tmpSource { get; set; }
        private static byte[] tmpHash { get; set; }


        public static String Hash(string source)
        {
            tmpSource = ASCIIEncoding.ASCII.GetBytes(source);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            System.Diagnostics.Debug.WriteLine(ASCIIEncoding.ASCII.GetString(tmpHash));
            return ASCIIEncoding.ASCII.GetString(tmpHash);
        }

/*        public static String Dehash(string source)
        {
            tmpSource = ASCIIEncoding.ASCII.GetBytes(source);
            tmpHash = new MD5CryptoServiceProvider().
        }*/
    }
}
