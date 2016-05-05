using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using atmelstudio_cppcheck.Parser;

namespace atmelstudio_cppcheck.test
{
    [TestClass]
    public class CppCheckResultParserTest
    {
        [TestMethod]
        [TestCategory("result-parser")]
        public void InvalidVersionGivesNullParser()
        {
            var parser = CppCheckParserFactory.GetParser(CppCheckXmlOutput.ResultsInvalidVersion);

            Assert.IsNull(parser, "Giving a result xml with unknown version should return a null");
        }


        [TestMethod]
        [TestCategory("result-parser")]
        public void ParseVersion1Data()
        {
            var parser = CppCheckParserFactory.GetParser(CppCheckXmlOutput.ResultsVersion1);

            var result = parser.Parse().ToList();

            Assert.AreEqual(1, parser.Version());
            Assert.AreEqual(3, result.Count);


            var firstError = result.First();
            Assert.AreEqual(1, firstError.Locations.ToList().Count);

            var location = firstError.Locations.First();

            Assert.AreEqual("led_flasher_main.c", location.File);
            Assert.AreEqual(12, location.Line);

            Assert.AreEqual(CppCheckError.CppCheckErrorSeverity.Style, firstError.Severity);
            Assert.AreEqual("unreadVariable", firstError.Type);
            Assert.IsFalse(firstError.Inconclusive.HasValue);
        }

        [TestMethod]
        [TestCategory("result-parser")]
        public void ParseVersion2Data()
        {
            var parser = CppCheckParserFactory.GetParser(CppCheckXmlOutput.ResultsVersion2);

            var result = parser.Parse().ToList();

            Assert.AreEqual(2, parser.Version());
            Assert.AreEqual(3, result.Count);


            var firstError = result.First();
            Assert.AreEqual(1, firstError.Locations.ToList().Count);

            var location = firstError.Locations.First();

            Assert.AreEqual("led_flasher_main.c", location.File);
            Assert.AreEqual(12, location.Line);

            Assert.AreEqual(CppCheckError.CppCheckErrorSeverity.Style, firstError.Severity);
            Assert.AreEqual("unreadVariable", firstError.Type);
            Assert.IsFalse(firstError.Inconclusive.HasValue);
            
            var parser2 = (CppCheckParserV2)parser;
            Assert.AreEqual("1.73", parser2.CppCheckVersion);

        }
    }
}
