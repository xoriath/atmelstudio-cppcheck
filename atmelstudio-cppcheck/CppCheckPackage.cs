//------------------------------------------------------------------------------
// <copyright file="CppCheckPackage.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using Microsoft.VisualStudio.ExtensionManager;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace atmelstudio_cppcheck
{
    [ProvideAutoLoad(UIContextGuids80.SolutionExists)]
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [Guid(CppCheckPackage.PackageGuidString)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class CppCheckPackage : Package
    {
        public const string PackageGuidString = "0ad30a47-4ea7-42f1-a6b4-4544b7c7f5e4";
        public CppCheckPackage()
        {
            
        }

        
        protected override void Initialize()
        {
            base.Initialize();

            TaskManager.Initialize(this);


        }
    }
}
