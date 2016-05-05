using Microsoft.VisualStudio.ExtensionManager;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmelstudio_cppcheck.Utilities
{
    class ExtensionServiceHelpers
    {

        private static IVsExtensionManager extensionManager;
        private static IInstalledExtension self;
        private static string selfIdentifier = "atmelstudio_cppcheck.Morten Engelhardt Olsen.07a40119-2a62-4379-9973-ae3bd3707e0d";

        public static string GetAssetLocation(IServiceProvider serviceProvider, string assetIdentifier)
        {
            if (extensionManager == null)
                extensionManager = serviceProvider.GetService(typeof(SExtensionManager)) as IVsExtensionManager;

            if (self == null)
                self = extensionManager.GetInstalledExtension(selfIdentifier);
            
            var content = self.Content.Where(e => e.ContentTypeName.Equals(assetIdentifier)).FirstOrDefault();

            if (content == null)
                return null;

            return Path.Combine(self.InstallPath, content.RelativePath);
        }

    }
}
