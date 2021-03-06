﻿using System;
using System.Text.RegularExpressions;

namespace atmelstudio_cppcheck.Runner
{
    // File check output:           'Checking Device_Startup\startup_samd10.c...'
    // File check specific conf:    'Checking hal\hpl\gclk\hpl_gclk1_v210_base.c: CONF_GCLK_GENERATOR_0_CONFIG=1...'
    // Progress update:             '5/21 files checked 21% done'

    public class CppCheckOutputParser
    {

        private readonly Regex FileCheckRegex = new Regex(@"Checking (.*)...", RegexOptions.Compiled);
        private readonly Regex FileConfigurationCheckRegex = new Regex(@"Checking (.*): (.*)...", RegexOptions.Compiled);
        private readonly Regex ProgressRegex = new Regex(@"(\d+)\/(\d+) files checked (.*)% done", RegexOptions.Compiled);

        public event EventHandler<ProgressEventArgs> Progress;
        public event EventHandler<FileCheckEventArgs> FileCheck;
        public event EventHandler<FileConfigurationCheckEventArgs> FileConfigurationCheck;

        public int FileNumber { get; private set; }
        public int TotalFiles { get; private set; }
        public int Percent { get; private set; }
        public string FileName { get; private set; }
        public string Configuration { get; private set; }

        public bool ParseLine(string line)
        {
            if (FileConfigurationCheckRegex.IsMatch(line)) // With config also matches just file, so check this one first
                return ParseFileConfigurationCheckLine(line);
            else if (FileCheckRegex.IsMatch(line))
                return ParseFileCheckLine(line);
            else if (ProgressRegex.IsMatch(line))
                return ParseProgressLine(line);
            else
                return false;
        }

        private bool ParseProgressLine(string line)
        {
            var match = ProgressRegex.Match(line);

            var fileNumberString = match.Groups[1].Value;
            var totalFileNumberString = match.Groups[2].Value;
            var progressString = match.Groups[3].Value;

            SetProgress(fileNumberString, totalFileNumberString, progressString);

            return true;
        }
        private bool ParseFileCheckLine(string line)
        {
            var match = FileCheckRegex.Match(line);

            FileName = match.Groups[1].Value;

            OnFileNameChanged();

            return true;
        }

        private bool ParseFileConfigurationCheckLine(string line)
        {
            var match = FileConfigurationCheckRegex.Match(line);

            FileName = match.Groups[1].Value;
            Configuration = match.Groups[2].Value;

            OnFileAndConfigurationChanged();

            return true;
        }



        private void SetProgress(string fileNumberString, string totalFileNumberString, string progressString)
        {
            int fileNumber, totalFiles, percent;
            if (!int.TryParse(fileNumberString, out fileNumber))
                fileNumber = 0;
            if (!int.TryParse(totalFileNumberString, out totalFiles))
                totalFiles = 0;
            if (!int.TryParse(progressString, out percent))
                percent = 0;

            FileNumber = fileNumber;
            TotalFiles = totalFiles;
            Percent = percent;

            OnProgressChanged();
        }

        private void OnProgressChanged()
        {
            if (Progress != null)
                Progress(this, new ProgressEventArgs { FileNumber = FileNumber, TotalFiles = TotalFiles, Percent = Percent });
        }

        private void OnFileAndConfigurationChanged()
        {
            if (FileConfigurationCheck != null)
                FileConfigurationCheck(this, new FileConfigurationCheckEventArgs { FileName = FileName, Configuration = Configuration });
        }

        
        private void OnFileNameChanged()
        {
            if (FileCheck != null)
                FileCheck(this, new FileCheckEventArgs { FileName = FileName });
        }
    }
}
