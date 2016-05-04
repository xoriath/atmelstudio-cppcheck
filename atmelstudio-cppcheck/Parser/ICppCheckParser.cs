using System.Collections.Generic;

namespace atmelstudio_cppcheck.Parser
{
    public interface ICppCheckParser
    {
        IEnumerable<CppCheckError> Parse();

        int Version();
    }
}