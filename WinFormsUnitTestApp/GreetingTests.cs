using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsTestApp;
    
    namespace WinFormsUnitTestApp
{
    [TestClass]
    public sealed class GreetingTests
    {
        [TestMethod]
        public void CreateGreeting_ReturnsCorrectMessage()
        {
            // Arrange
            Form1 form = new Form1();

            // Act
            string result = form.CreateGreeting("Iryna");

            // Assert
            Assert.AreEqual("Hello, Iryna!", result);
        }

        [TestMethod]
        public void CreateGreeting_ReturnsNull_WhenEmpty()
        {
            Form1 form = new Form1();

            string result = form.CreateGreeting("");

            Assert.IsNull(result);
        }
        public void TestMethod1()
        {
        }
    }
}
