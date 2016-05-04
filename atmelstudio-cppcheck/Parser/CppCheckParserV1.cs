using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Linq;
using System.Net;

namespace atmelstudio_cppcheck.Parser
{
    internal class CppCheckParserV1 : ICppCheckParser
    {
        private XElement results;

        public CppCheckParserV1(XElement results)
        {
            this.results = results;
        }

        public IEnumerable<CppCheckError> Parse()
        {
            return results.XPathSelectElements("//error").Select(error =>
                new CppCheckError()
                    {
                        Type = error.Attribute("id").Value,
                        Message = WebUtility.HtmlDecode(error.Attribute("msg").Value),
                        Severity = CppCheckError.ErrorSeverityFromString(error.Attribute("severity").Value),
                        Locations = new List<CppCheckErrorLocation>() 
                            {
                                new CppCheckErrorLocation(file:error.Attribute("file").Value, line:error.Attribute("line").Value)
                            }
                    }
                );
        }

        public int Version()
        {
            return 1;
        }
    }
}