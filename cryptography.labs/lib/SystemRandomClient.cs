using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    /*
    System.Random is based on Substrative Random Number generator by Donald E. Knuth
    Microsoft recommends creating 1 instance of System.Random fo rthe application
    System.Random is not thread safe.
    */
    public class SystemRandomClient
    {
        /*
       Give the constructor a seed value.
       Give the min and max limit in the random.Next()
       If you keep the same seed and same min/max limit, you would get the same random numbers.
       -4 -7  0  9 -9 -10  9  8  9 -1
       */
        public static void GenerateRandomNumbers()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Random random = new Random(250);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0,3}", random.Next(-10, 11));
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        /*
        Uses the current timestamp as seed. So the numbers would be different
        */
        public static void GenerateRandomNumbersWithTimestamp()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0,3}", random.Next(-10, 11));
            }
            Console.ResetColor();
            Console.WriteLine();

        }
    }
}
