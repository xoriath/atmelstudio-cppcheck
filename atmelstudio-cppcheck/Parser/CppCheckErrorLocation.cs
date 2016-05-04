namespace atmelstudio_cppcheck.Parser
{
    public class CppCheckErrorLocation
    {
        public string File { get; private set; }

        public int Line { get; private set; }

        public string Message { get; private set; }

        public CppCheckErrorLocation(string file, string line, string message = "")
        {
            File = file;
            Message = message;

            int lineInt;
            if (int.TryParse(line, out lineInt))
                Line = lineInt;
            else
                Line = -1;
        }

        public CppCheckErrorLocation(string file, int line, string message = "")
        {
            File = file;
            Line = line;
            Message = message;
        }
    }
}
