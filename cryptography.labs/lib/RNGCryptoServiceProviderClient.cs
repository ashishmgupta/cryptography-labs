using System.Security.Cryptography;

namespace lib
{
    /*
    System.Random is not good doe non-deterministic random numbers
    RNGCryptoServiceProvider is more secure way to generate random numbers
    RNGCryptoService Provider is slower than using System.Random class.
    RNGCryptoServiceProvider is thread safe
    The java equivalent would be SecureRandom class.
    */
    public class RNGCryptoServiceProviderClient
    {

        public static byte[] GenerateRandomNumber(int length)
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[length];
                randomNumberGenerator.GetBytes(randomNumber);
                return randomNumber;
            }
        }
    }
}
