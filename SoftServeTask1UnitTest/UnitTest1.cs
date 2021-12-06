using NUnit.Framework;
using SoftServeTask1;

namespace SoftServeTask1UnitTest
{
    [TestFixture]
    public class Tests
    {
        TriangleController controller;
        View view;

        [SetUp]
        public void Setup()
        {
            controller = new TriangleController();
            view = new View();
        }

        [Test]
        [Category("Controller")]
        [TestCase(10.0, 10.0, 15.0)]
        public void Test_IsTrianglePositive(double a, double b, double c)
        {
            Setup();
            //bool expectedResult = true;
            bool actualResult = controller.IsTriangle(a, b, c);
            Assert.IsTrue(actualResult, "I should not be false");
        }

        [Test]
        [Category("Controller")]
        [TestCase(100.0, 10.7, 15.24)]
        public void Test_IsTriangleNegative(double a, double b, double c)
        {
            Setup();
            bool result = controller.IsTriangle(a, b, c);
            Assert.IsFalse(result, "I should not be true");
        }

        [TearDown]
        public void Clear()
        {
            controller = null;
            view = null;
        }
    }
}