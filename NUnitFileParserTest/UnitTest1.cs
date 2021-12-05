using NUnit.Framework;
using FileParser;

namespace NUnitFileParserTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        [Category("StaticParser")]
        [TestCase(2, "Wo", new string[] {"Text", "SomethingWoWoWoWWoooWo", "Happend" })]
        public void Test_ToFindSubStringCheck(int lineNum, string subString, string[] lines)
        {
            Assert.AreEqual(5, StaticParser.FindSubString(lineNum, subString, lines));
        }
    }
}