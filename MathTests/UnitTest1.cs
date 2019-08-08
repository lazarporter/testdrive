using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicRooterTest()
        {
            // Create a test instance:
            Rooter rooter = new Rooter();
            // Define a test input and expected result:
            double input = expectedResult * expectedResult;
            double expectedResult = 2.0;
            
            // Call the method being tested:
            double actualResult = rooter.SquareRoot(input);
            // Check the result:
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }
    }
}
