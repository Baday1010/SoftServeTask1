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
            //view = new View(10, 10, 15, "first");
            controller = new TriangleController();
        }

       
        public void Test1()
        {
            Assert.Pass();
        }

        [TestCase(12, 3, 4)]
        [TestCase(12, 2, 6)]
        [TestCase(12, 4, 3)]
        [Test]
        public void DivideTest(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }
        [Test]
        [Category("Controller")]
        //[TestCase(10, 10, 15, ExpectedResult = true)]
        public void Test_IsTrianglePositive()
        {
            //Setup();
            //bool result = controller.IsTriangle(view);
            ////Assert.IsTrue(result, "I should not be false");
            //Assert.That(result, Is.EqualTo(true));
        }

        [TearDown]
        public void Clear()
        {
            controller = null;
            view = null;
        }
    }
}