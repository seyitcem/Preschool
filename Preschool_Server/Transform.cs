using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Server
{
    static class Transform
    {
        static public string StringToHexString(string str)
        {
            StringBuilder hex = new StringBuilder();

            byte[] bytes = Encoding.UTF8.GetBytes(str.ToString());
            foreach (var t in bytes)
            {
                hex.Append(t.ToString("X2"));
            }
            return hex.ToString();
        }
        static public string HexStringToString(string hex)
        {
            var bytes = new byte[hex.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
