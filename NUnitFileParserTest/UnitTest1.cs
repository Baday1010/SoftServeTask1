using NUnit.Framework;
using Parser;

namespace NUnitFileParserTest
{
    public class Tests
    {

        [Test]
        [Category("StaticParser")]
        [TestCase(2, "Wo", new string[] { "Text", "SomethingWoWoWoWWoooWo", "Happend" })]
        public void Test_ToFindSubStringCheck(int lineNum, string subString, string[] lines)
        {
            int expectedResult = 5;
            Assert.AreEqual(expectedResult, StaticParser.FindSubString(lineNum, subString, lines));
        }

        [Test]
        [Category("StaticParser")]
        [TestCase(1, "_", "45", new string[] { "123_6", "Hello" })]
        public void Test_ToFindAndReplaceSubStringCheck(int lineNum, string subStrToSearch, string subStrToReplace, string[] lines)
        {
            string expectedResult = "123456";
            Assert.AreEqual(expectedResult, StaticParser.FindAndReplaceSubString(lineNum, subStrToSearch, subStrToReplace , lines));
        }
    }
}