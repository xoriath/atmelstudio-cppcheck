
using System.Collections.Generic;

namespace atmelstudio_cppcheck.Runner
{
    class CppCheckRunner
    {
        public List<string> Arguments = new List<string>
            {
                "--enable=warning,style,performance,portability",
                "-iDebug", // ignore debug folder (assume running from project folder)
                "-iRelease", // ignore Release folder (assume running from project folder)
                "--error-exitcode=2", // if errors detected, return code 2
                "--file-list=<file>", // newline separated file of files to check...
                "-i <dir>", // include folders
                "--inline-suppr", // enable inline suppression
                "-j 4", // parallel!
                "--language=<c,c++>", // force language
                "--force", // check ALL configs
                "--platform=<platform file>", // load platform file
                "--report-progress",
                "--xml", // write xml to error
                "--xml-version=2", // xml version to write
                "-D<define>",
                "-U<undef>",
            };
    }
}
