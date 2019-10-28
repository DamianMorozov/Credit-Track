using System;

namespace LibWin
{
    public sealed class Process
    {
        #region Design pattern "Singleton".

        private static readonly Lazy<Process> _instance = new Lazy<Process>(() => new Process());
        public static Process Instance { get { return _instance.Value; } }
        private Process()
        {
            Init();
        }

        public void Init()
        {
            //
        }

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
