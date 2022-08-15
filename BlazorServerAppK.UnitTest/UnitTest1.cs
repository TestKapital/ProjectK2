using NUnit.Framework;

namespace BlazorServerAppK.UnitTest
{
    public class Tests
    {
        private Bunit.TestContext testContext;
        [SetUp]
        public void Setup()
        {
            testContext = new Bunit.TestContext();
        }

        [TearDown]
        public void Teardown()
        {
            testContext.Dispose();
        }

        [Test]
        public void Test1()
        {
            // Arrange
            // Act
            // Assert

            Assert.Pass();
        }
    }
}