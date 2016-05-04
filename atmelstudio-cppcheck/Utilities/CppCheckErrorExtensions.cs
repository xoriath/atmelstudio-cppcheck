using System;

namespace atmelstudio_cppcheck.Utilities
{
    public static class CppCheckErrorExtensions
    {
        public static Uri CweUrl(this Parser.CppCheckError error)
        {
            if (string.IsNullOrEmpty(error.CommonWeaknessEnumeration))
                return null;

            return new Uri(string.Format("https://cwe.mitre.org/data/definitions/{0}.html", error.CommonWeaknessEnumeration));
        }
    }
}
