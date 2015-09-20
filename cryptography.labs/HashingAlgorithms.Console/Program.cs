using lib;
using System;
namespace HashingAlgorithms.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputMessage1 = "Test message";
            string inputMessage2 = "Test message";

            System.Console.WriteLine(HashHelper.GetMD5Hash(inputMessage1));
            System.Console.WriteLine(HashHelper.GetMD5Hash(inputMessage2));


            System.Console.WriteLine("=======================");

            System.Console.WriteLine(HashHelper.GetSHA1Hash(inputMessage1));
            System.Console.WriteLine(HashHelper.GetSHA1Hash(inputMessage2));

            System.Console.WriteLine("=======================");

            System.Console.WriteLine(HashHelper.GetSHA256Hash(inputMessage1));
            System.Console.WriteLine(HashHelper.GetSHA256Hash(inputMessage2));

            System.Console.WriteLine("=======================");

            System.Console.WriteLine(HashHelper.GetSHA512Hash(inputMessage1));
            System.Console.WriteLine(HashHelper.GetSHA512Hash(inputMessage2));

            System.Console.ReadLine();
        }
    }
}
