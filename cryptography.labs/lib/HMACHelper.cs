using System.Security.Cryptography;

namespace lib
{
    /*
    HMAC : Hash Based Message Authentication Code
    Ensures both Integrity and Authenticity

    Integrity : The message is hashed and any change in the message wont give the same hash.
    So It provides integrity. For hashing MD5, SHA1 or SHA2 can be used.
    
    Authenticity : The message can also be protedted by a key. 
    Only the person who knows the keys can calculate the hash.
    
    HMAC adds entropy to the hashing algorithm becuase of the secret key. 
    So It is less vunerable from bruce force attack than the hashing algorithm (MD5, SHA1 and SHA2) alone.
    */
    public class HMACHelper
    {

        public static byte[] GetHMAC_SHA1(byte[] messageToBeHashed, byte[] key)
        {
            using (var hmacSHA1 = new HMACSHA1(key))
            {
                return hmacSHA1.ComputeHash(messageToBeHashed);
            }
        }

        public static byte[] GetHMAC_SHA256(byte[] messageToBeHashed, byte[] key)
        {
            using (var hmacSHA256 = new HMACSHA256(key))
            {
                return hmacSHA256.ComputeHash(messageToBeHashed);
            }
        }

        public static byte[] GetHMAC_SHA512(byte[] messageToBeHashed, byte[] key)
        {
            using (var hmacSHA512 = new HMACSHA1(key))
            {
                return hmacSHA512.ComputeHash(messageToBeHashed);
            }
        }

        public static byte[] GetHMAC_MD5(byte[] messageToBeHashed, byte[] key)
        {
            using (var hmacMD5 = new HMACMD5(key))
            {
                return hmacMD5.ComputeHash(messageToBeHashed);
            }
        }
    }
}
