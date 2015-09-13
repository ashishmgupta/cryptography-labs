using lib;
using System;


namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsingSystemRandom();
            UsingRNGCryptoServiceProvider();
            Console.Read();
        }


        private static void UsingSystemRandom()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Using same seed and with same min/max limit");
                SystemRandomClient.GenerateRandomNumbers();
                Console.WriteLine();
                Console.WriteLine("using current timestamp as seed and with same min/max limit");
                SystemRandomClient.GenerateRandomNumbersWithTimestamp();
            }
        }


        private static void UsingRNGCryptoServiceProvider()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Random number number {0} : {1}", 
                    i, 
                    Convert.ToBase64String (RNGCryptoServiceProviderClient.GenerateRandomNumber(32)));
            }
        }

    }
}
