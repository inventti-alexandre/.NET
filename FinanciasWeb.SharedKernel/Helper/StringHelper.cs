using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.SharedKernel.Helper
{
    public static class StringHelper
    {
        public static string Encrypt(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            value += "|54be1d80-b6d0-45c0-b8d7-13b3c798729f";
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] data = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(value));
            System.Text.StringBuilder sbString = new System.Text.StringBuilder();
            for(int i = 0; i < data.Length; i++)
               sbString.Append(data[i].ToString("x2"));

            return sbString.ToString();
        }

        public static string Encrypttests(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.ASCII.GetBytes(value));
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
                str.Append(data[i].ToString("x2"));

            return str.ToString();
        }
    }
}
