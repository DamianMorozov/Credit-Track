using System;

namespace LibWin
{
    public sealed class Process
    {
        #region Design pattern "Lazy Singleton"

        private static readonly Lazy<Process> _instance = new Lazy<Process>(() => new Process());
        public static Process Instance => _instance.Value;
        private Process() { }

        #endregion

        public void Run(string procName)
        {
            var process = new System.Diagnostics.Process
            {
                StartInfo =
                {
                    FileName = procName.EndsWith(".exe") ? procName : procName + ".exe",
                    Arguments = "",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                    CreateNoWindow = false
                }
            };
            process.Start();
            process.WaitForExit();
        }
    }
}
