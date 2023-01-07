using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Toplearn.Core.Security
{
   public class PasswordHelper
    {
        public static string EncodePasswordMd5(string pass)//Encrypt using MD5

        {
            byte[] orginalBytes;
            byte[] encodedBytes;
            MD5 md5;
            md5 = new MD5CryptoServiceProvider();
            orginalBytes = ASCIIEncoding.Default.GetBytes(pass);
            encodedBytes = md5.ComputeHash(orginalBytes);
            return BitConverter.ToString(encodedBytes);

        }
    }
}
