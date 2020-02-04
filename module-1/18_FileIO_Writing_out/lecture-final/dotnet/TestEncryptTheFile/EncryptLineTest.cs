using EncryptTheFile;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEncryptTheFile
{
    [TestClass]
    public class EncryptLineTest
    {
        [TestMethod]
        public void TestEncryptBy2()
        {
            string test = "abc";
            string result  = EncryptLine.Encrypt(test, 3);
            Assert.AreEqual("def", result);
        }

        [TestMethod]
        public void TestEncryptSpace()
        {
            string test = " ";
            string result = EncryptLine.Encrypt(test, 3);
            Assert.AreEqual("#", result);
        }
    }
}
