
using System.Collections.Generic;
using System;
using atmelstudio_cppcheck.Utilities;

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

        private IServiceProvider serviceProvider;
        private CppCheckRunner(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;

            InitializePlatformXml();
        }

        private Dictionary<string, string> platformXml = new Dictionary<string, string>();
        private void InitializePlatformXml()
        {
            platformXml["avr8"] = ExtensionServiceHelpers.GetAssetLocation(serviceProvider, "CppCheck.Platform.AVR8");
            platformXml["avr32"] = ExtensionServiceHelpers.GetAssetLocation(serviceProvider, "CppCheck.Platform.AVR32");
            platformXml["arm-cm"] = ExtensionServiceHelpers.GetAssetLocation(serviceProvider, "CppCheck.Platform.ARM-CORTEX-M");
        }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            if (instance == null)
                instance = new CppCheckRunner(serviceProvider);
        }

        private static CppCheckRunner instance = null;

        public static CppCheckRunner Instance => instance;
    }
}
