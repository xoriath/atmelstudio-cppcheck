using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using System.Xml.XPath;

namespace atmelstudio_cppcheck.Parser
{
    internal class CppCheckParserV2 : ICppCheckParser
    {
        private XElement results;

        public CppCheckParserV2(XElement results)
        {
            this.results = results;
            this.CppCheckVersion = results.Descendants("cppcheck").First().Attribute("version").Value;
        }

        public IEnumerable<CppCheckError> Parse()
        {
            return results.XPathSelectElements("//error").Select(error =>
                new CppCheckError()
                    {
                        Type = error.Attribute("id").Value,
                        Message = WebUtility.HtmlDecode(error.Attribute("msg").Value),
                        Severity = CppCheckError.ErrorSeverityFromString(error.Attribute("severity").Value),
                        Locations = error.XPathSelectElements(".//location").Select(location => 
                            new CppCheckErrorLocation(file:location.Attribute("file").Value, line:location.Attribute("line").Value))
                    }
                );
        }

        public int Version()
        {
            return 2;
        }

        public string CppCheckVersion { get; private set; }
    }
}