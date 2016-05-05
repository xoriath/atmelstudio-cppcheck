using System;

namespace atmelstudio_cppcheck.Runner
{
    public class FileCheckEventArgs : EventArgs
    {
        public string FileName { get; set; }
    }
}
