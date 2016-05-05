using System;

namespace atmelstudio_cppcheck.Runner
{
    public class ProgressEventArgs : EventArgs
    {
        public int FileNumber { get; set; }
        public int TotalFiles { get; set; }
        public int Percent { get; set; }
    }
}
