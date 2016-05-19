using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lib.SymmetricEncryption
{
    /*
    AES (Advanced Encryption Standard)
    Symmetric Encryption - Same key is used for encryption and descryption.
    Currently unbroken
    Extremely secure
    Relatively fast

    Drawback - Same key needs to be shared with other party.
    So - This is good If you are not sharing the key. 
    Only you are encrypting data and you are decryptiong your own data

    */
    public class AES_Helper
    {
        public string Encrypt(string stringToEncrypt, string stringKey)
        {
            string encryptedString = string.Empty;
            byte[] bytesToEncrypt = CommonHelper.ConvertStringToBytes(stringToEncrypt);
            byte[] bytesKey = CommonHelper.ConvertStringToBytes(stringKey);

            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                aes.Key = bytesKey;
                //aes.IV 

                using (var memoryStream = new MemoryStream())
                {
                    var cryptoStream = new CryptoStream
                        (memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);

                    cryptoStream.Write(bytesToEncrypt, 0, bytesToEncrypt.Length);
                    cryptoStream.FlushFinalBlock();

                    if (memoryStream.ToArray() != null)
                    {
                        encryptedString = CommonHelper.ConvertBytesToString(memoryStream.ToArray());
                    }
                }
            }
            return encryptedString;
        }


        public string Decrypt(string stringToDecrypt, string stringKey)
        {
            string decryptedString = string.Empty;
            byte[] bytesToDecrypt = CommonHelper.ConvertStringToBytes(stringToDecrypt);
            byte[] bytesKey = CommonHelper.ConvertStringToBytes(stringKey);

            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                aes.Key = bytesKey;
                //aes.IV 

                using (var memoryStream = new MemoryStream())
                {
                    var cryptoStream = new CryptoStream
                        (memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);

                    cryptoStream.Write(bytesToDecrypt, 0, bytesToDecrypt.Length);
                    cryptoStream.FlushFinalBlock();

                    if (memoryStream.ToArray() != null)
                    {
                        decryptedString = CommonHelper.ConvertBytesToString(memoryStream.ToArray());
                    }
                }
            }
            return decryptedString;
           
        }

    }
}
