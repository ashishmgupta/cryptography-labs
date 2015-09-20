using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class CommonHelper
    {
        public static byte[] ConvertStringToBytes(string messageString)
        {
            return Encoding.Unicode.GetBytes(messageString);
        }

        public static string ConvertBytesToString(byte[] byteSting)
        {
            return Convert.ToBase64String(byteSting);
        }
    }
}
