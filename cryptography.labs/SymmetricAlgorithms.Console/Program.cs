using lib.SymmetricEncryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SymmetricAlgorithms.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AES_Helper helper = new AES_Helper();
            string stringToEncrypt = "Ashish";
            string key = "eabe9a2d363fccedceb79d22e3c1671c4493ad289a34ff2b9ca18ca29bd46fed";
            System.Console.WriteLine(helper.Encrypt(stringToEncrypt, key));
            System.Console.ReadLine();
        }
    }
}
