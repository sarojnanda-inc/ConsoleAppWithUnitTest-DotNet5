using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppWithUnitTest.ExtensionMethods;

namespace UnitTesting
{
    [TestClass]
    public class ConsoleUnitTest
    {
        [TestMethod]
        public void CheckDefaultReturnValueForInvalidInput()
        {
            string input = "Hello";
            int result = input.ToSafeInt(2);
            Assert.IsTrue(result == 2);

        }
        [TestMethod]
        public void CheckValidConversion()
        {
            string input = "56";
            int result = input.ToSafeInt(2);
            Assert.IsTrue(result == 56);

        }
    }
}
