using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lib
{

    /*
    Moores law :- The number of transistors in a Integrated Circuit double every 2 years.
    So over time the processors will become faster and they can be used to generate the same hash
    as the hash of your password.

    e.g. AMD Radeon HD 7970 Graphic card
    You see, using hashcat [http://hashcat.net/oclhashcat/] to leverage the power of the GPU 
    in the 7970 you can generate up to 4.7393 billion hashes per second. 
    That’s right, billion as in b for “bloody fast”.
    http://www.troyhunt.com/2012/06/our-password-hashing-has-no-clothes.html


    The solution is to use PBKDF2 [Password Based Ky Derivation Functions]
    This is the part of  :-
    a) RSA Public Key Cryptographoc Standards (PKCS #5 Version 2.0
    b) Internet Engineerting Task Force RFC 2898 Specification

   It takes password, adds a salt to it, 
   and a number of iteration value the hash operation need to applied on the original text.
   The more number of times the hashing operation is performed on the password, 
   more slower and therefore harder is to brute force attack to calculate the hash.
   This also means the comparing hashing would be slower during say..Login process.
   Remember, during the login process, you have to calculate the hash using the same process and compare the hash 
   with the stored hashed password in the database.

    Related .NET class for this is Rfc2898DeriveBytes [System.Security.Cryptography]
    Related Java class for this is PBKDF2WithHmacSHA1 
    */
    public class PBKDF2_Helper
    {
        public static byte[] GetHashedPassword(byte[] messageBytes, byte[] salt, int numberOfRounds)
        {
            using (var rfc2898DerivedBytes = new Rfc2898DeriveBytes(messageBytes, salt, numberOfRounds))
            {
                return rfc2898DerivedBytes.GetBytes(32);
            }
        }
    }
}
