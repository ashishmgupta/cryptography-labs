using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lib.SymmetricEncryption
{
    public class DES_Helper
    {
        public byte[] Encrypt(byte[] dataToEncryptBytes, byte[] key, byte[] initializationVector)
        {
            byte[] encryptedBytes = null;
            CryptoStream cryptoStream = null;
            using (var des = new DESCryptoServiceProvider())
            {
                des.Mode = CipherMode.CBC;
                des.Padding = PaddingMode.PKCS7;

                des.Key = key;
                des.IV = initializationVector;

                using (var memoryStream = new MemoryStream())
                {
                    using (cryptoStream = new CryptoStream
                       (memoryStream, des.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(dataToEncryptBytes, 0, dataToEncryptBytes.Length);
                        cryptoStream.FlushFinalBlock();

                        encryptedBytes = memoryStream.ToArray();
                    }

                }

                return encryptedBytes;
            }
        }
    }
}
