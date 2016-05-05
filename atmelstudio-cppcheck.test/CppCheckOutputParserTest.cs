using atmelstudio_cppcheck.Runner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace atmelstudio_cppcheck.test
{
    [TestClass]
    public class CppCheckOutputParserTest
    {
        [TestMethod]
        [TestCategory("output-parser")]
        public void SingleProgress()
        {
            var line = @"4/21 files checked 14% done";

            var parser = new CppCheckOutputParser();
            var eventCalled = false;
            var otherEventsCalled = false;

            parser.FileCheck += (s, e) => otherEventsCalled = true;
            parser.FileConfigurationCheck += (s, e) => otherEventsCalled = true;

            parser.Progress += delegate (object sender, ProgressEventArgs e)
            {
                Assert.AreEqual(4, e.FileNumber);
                Assert.AreEqual(21, e.TotalFiles);
                Assert.AreEqual(14, e.Percent);

                eventCalled = true;
            };
            
            Assert.IsTrue(parser.ParseLine(line));
            Assert.AreEqual(4, parser.FileNumber);
            Assert.AreEqual(21, parser.TotalFiles);
            Assert.AreEqual(14, parser.Percent);

            Assert.IsTrue(eventCalled);
            Assert.IsFalse(otherEventsCalled);
        }

        [TestMethod]
        [TestCategory("output-parser")]
        public void SingleFileChange()
        {
            var line = @"Checking hal\hpl\port\hpl_port_v100.c...";

            var parser = new CppCheckOutputParser();
            var eventCalled = false;
            var otherEventsCalled = false;

            parser.Progress += (s, e) => otherEventsCalled = true;
            parser.FileConfigurationCheck += (s, e) => otherEventsCalled = true;

            parser.FileCheck += delegate (object sender, FileCheckEventArgs e)
            {
                Assert.AreEqual(@"hal\hpl\port\hpl_port_v100.c", e.FileName);
                eventCalled = true;
            };

            Assert.IsTrue(parser.ParseLine(line));
            Assert.AreEqual(@"hal\hpl\port\hpl_port_v100.c", parser.FileName);
            
            Assert.IsTrue(eventCalled);
            Assert.IsFalse(otherEventsCalled);
        }

        [TestMethod]
        [TestCategory("output-parser")]
        public void SingleFileChangeWithConfig()
        {
            var line = @"Checking hal\hpl\gclk\hpl_gclk1_v210_base.c: CONF_GCLK_GENERATOR_6_CONFIG=1...";

            var parser = new CppCheckOutputParser();
            var eventCalled = false;
            var otherEventsCalled = false;

            parser.Progress += (s, e) => otherEventsCalled = true;
            parser.FileCheck += (s, e) => otherEventsCalled = true;
            parser.FileConfigurationCheck += delegate (object sender, FileConfigurationCheckEventArgs e)
            {
                Assert.AreEqual(@"hal\hpl\gclk\hpl_gclk1_v210_base.c", e.FileName);
                Assert.AreEqual(@"CONF_GCLK_GENERATOR_6_CONFIG=1", e.Configuration);                

                eventCalled = true;
            };

            Assert.IsTrue(parser.ParseLine(line));
            Assert.AreEqual(@"hal\hpl\gclk\hpl_gclk1_v210_base.c", parser.FileName);
            Assert.AreEqual(@"CONF_GCLK_GENERATOR_6_CONFIG=1", parser.Configuration);

            Assert.IsTrue(eventCalled);
            Assert.IsFalse(otherEventsCalled);
        }
    }
}
