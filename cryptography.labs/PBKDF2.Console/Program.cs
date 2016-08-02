using lib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBKDF2.Console
{
    class Program
    {
        static byte[]  salt = null;
        static string plainPassword = "pa$$w0rd%%%%WEEEE";
        static void Main(string[] args)
        {
            salt = RNGCryptoServiceProviderClient.GenerateRandomNumber(32);
            System.Console.WriteLine("Salt :" + CommonHelper.ConvertBytesToString(salt));
            GetHashedPassword(plainPassword, 10);
            GetHashedPassword(plainPassword, 50);
            GetHashedPassword(plainPassword, 100);
            GetHashedPassword(plainPassword, 200);
            GetHashedPassword(plainPassword, 500);
            GetHashedPassword(plainPassword, 1000);
            GetHashedPassword(plainPassword, 5000);
            GetHashedPassword(plainPassword, 10000);
            GetHashedPassword(plainPassword, 20000);
            GetHashedPassword(plainPassword, 30000);
            GetHashedPassword(plainPassword, 40000);
            GetHashedPassword(plainPassword, 50000);
            GetHashedPassword(plainPassword, 100000);
            System.Console.ReadLine();
        }

        private static void GetHashedPassword(string messageTohash, int numberOfIterations)
        {
            byte[] messageBytes = CommonHelper.ConvertStringToBytes(messageTohash);
            Stopwatch stopWatch = Stopwatch.StartNew();
            stopWatch.Start();
            PBKDF2_Helper.GetHashedPassword(messageBytes, salt, numberOfIterations);
            stopWatch.Stop();
            System.Console.WriteLine("For {0} Iterations - {1} milliseconds", numberOfIterations, stopWatch.ElapsedMilliseconds);
            System.Console.WriteLine("#################################################");
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }
}
