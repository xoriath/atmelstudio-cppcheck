using System.Collections.Generic;

namespace atmelstudio_cppcheck.Parser
{
    public class CppCheckError
    {
        public string Type { get; /*private*/ set; }

        public CppCheckErrorSeverity Severity { get; /*private*/ set; }

        private string message;
        public string Message 
        { 
            get { return message ?? string.Empty; }
            set { message = value ?? string.Empty; }
        }

        private string verboseMessage;
        public string VerboseMessage
        {
            get { return verboseMessage ?? string.Empty; }
            set { verboseMessage = value ?? string.Empty; }
        }

        public bool? Inconclusive { get; set; } = null;

        public string CommonWeaknessEnumeration { get; set; }

        public IEnumerable<CppCheckErrorLocation> Locations { get; /*private*/ set; }

        public enum CppCheckErrorSeverity { Error, Warning, Style, Performance, Portability, Information, Unknown };

        public static CppCheckErrorSeverity ErrorSeverityFromString(string error)
        {
            switch(error.ToLowerInvariant().Trim())
            {
                case "error":
                    return CppCheckErrorSeverity.Error;
                case "warning":
                    return CppCheckErrorSeverity.Warning;
                case "style":
                    return CppCheckErrorSeverity.Style;
                case "performance":
                    return CppCheckErrorSeverity.Performance;
                case "portability":
                    return CppCheckErrorSeverity.Portability;
                case "information":
                    return CppCheckErrorSeverity.Information;
                default:
                    return CppCheckErrorSeverity.Unknown;
            }
        }
    }
}
