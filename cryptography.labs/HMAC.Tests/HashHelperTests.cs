using Microsoft.VisualStudio.TestTools.UnitTesting;
using lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HMAC.Tests
{
    [TestClass()]
    public class HMACHelperTests
    {

        string message1 = string.Empty;
        string sameMessageAsMessage1 = string.Empty;
        string differentMessageThanMessage1 = string.Empty;

        byte[] message1Bytes = null;
        byte[] sameMessageAsMessage1Bytes = null;
        byte[] differentMessageThanMessage1Bytes = null;

        byte[] randomSecretKey = null;
        [TestInitialize]
        public void TestInitialize()
        {
            message1 = "This is a test message";
            sameMessageAsMessage1 = "This is a test message";
            differentMessageThanMessage1 = "This is a another message";

            message1Bytes = CommonHelper.ConvertStringToBytes(message1);
            sameMessageAsMessage1Bytes = CommonHelper.ConvertStringToBytes(sameMessageAsMessage1);
            differentMessageThanMessage1Bytes= CommonHelper.ConvertStringToBytes(differentMessageThanMessage1);

            randomSecretKey = RNGCryptoServiceProviderClient.GenerateRandomNumber(10);
        }

        [TestMethod()]
        public void MD5Hash_SameMessage_HashEqual()
        {
            byte[] hash1 = HMACHelper.GetHMAC_MD5(message1Bytes, randomSecretKey);
            byte[] hash2 = HMACHelper.GetHMAC_MD5(sameMessageAsMessage1Bytes, randomSecretKey);
            Trace.WriteLine("Hello");
            Trace.WriteLine(CommonHelper.ConvertBytesToString(hash1));
            Trace.WriteLine(CommonHelper.ConvertBytesToString(hash2));
            bool isEqual = hash1.SequenceEqual(hash2);
            Assert.IsTrue(isEqual);
        }


        [TestMethod()]
        public void MD5Hash_DifferentMessage_HashDifferent()
        {
            byte[] hash1 = HMACHelper.GetHMAC_MD5(message1Bytes, randomSecretKey);
            byte[] hash2 = HMACHelper.GetHMAC_MD5(differentMessageThanMessage1Bytes, randomSecretKey);
            Trace.WriteLine(CommonHelper.ConvertBytesToString(hash1));
            Trace.WriteLine(CommonHelper.ConvertBytesToString(hash2));
            bool isEqual = hash1.SequenceEqual(hash2);
            Assert.IsFalse(isEqual);
        }


        [TestMethod()]
        public void SHA1Hash_SameMessage_HashEqual()
        {
            byte[] hash1 = HMACHelper.GetHMAC_SHA1(message1Bytes, randomSecretKey);
            byte[] hash2 = HMACHelper.GetHMAC_SHA1(sameMessageAsMessage1Bytes, randomSecretKey);
            bool isEqual = hash1.SequenceEqual(hash2);
            Assert.IsTrue(isEqual);
        }



        [TestMethod()]
        public void SHA1Hash_DifferentMessage_HashDifferent()
        {
            byte[] hash1 = HMACHelper.GetHMAC_SHA1(message1Bytes, randomSecretKey);
            byte[] hash2 = HMACHelper.GetHMAC_SHA1(differentMessageThanMessage1Bytes, randomSecretKey);
            bool isEqual = hash1.SequenceEqual(hash2);
            Assert.IsFalse(isEqual);
        }


        [TestMethod()]
        public void SHA256Hash_SameMessage_HashEqual()
        {
            byte[] hash1 = HMACHelper.GetHMAC_SHA256(message1Bytes, randomSecretKey);
            byte[] hash2 = HMACHelper.GetHMAC_SHA256(sameMessageAsMessage1Bytes, randomSecretKey);
            bool isEqual = hash1.SequenceEqual(hash2);
            Assert.IsTrue(isEqual);
        }



        [TestMethod()]
        public void SHA256Hash_DifferentMessage_HashDifferent()
        {
            byte[] hash1 = HMACHelper.GetHMAC_SHA256(message1Bytes, randomSecretKey);
            byte[] hash2 = HMACHelper.GetHMAC_SHA256(differentMessageThanMessage1Bytes, randomSecretKey);
            bool isEqual = hash1.SequenceEqual(hash2);
            Assert.IsFalse(isEqual);
        }


        [TestMethod()]
        public void SHA512Hash_SameMessage_HashEqual()
        {
            byte[] hash1 = HMACHelper.GetHMAC_SHA512(message1Bytes, randomSecretKey);
            byte[] hash2 = HMACHelper.GetHMAC_SHA512(sameMessageAsMessage1Bytes, randomSecretKey);
            bool isEqual = hash1.SequenceEqual(hash2);
            Assert.IsTrue(isEqual);
        }



        [TestMethod()]
        public void SHA512Hash_DifferentMessage_HashDifferent()
        {
            byte[] hash1 = HMACHelper.GetHMAC_SHA512(message1Bytes, randomSecretKey);
            byte[] hash2 = HMACHelper.GetHMAC_SHA512(differentMessageThanMessage1Bytes, randomSecretKey);
            bool isEqual = hash1.SequenceEqual(hash2);
            Assert.IsFalse(isEqual);
        }

    }
}