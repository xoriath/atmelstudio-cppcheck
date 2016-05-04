using System;
using System.Xml.Linq;
using System.Xml.XPath;

namespace atmelstudio_cppcheck.Parser
{
    public class CppCheckParserFactory
    {
        public static ICppCheckParser GetParser(XElement results)
        {
            // If root element is <results version='2'>, return v2 parser, if number != 2 null else v1

            var root = results;

            var version = (int?)root.Attribute("version");

            if (!version.HasValue)
                return new CppCheckParserV1(results);
            else if (version.Value == 2)
                return new CppCheckParserV2(results);
            else
                return null;

        }
    }
}
