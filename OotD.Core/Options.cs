﻿using CommandLine;

namespace OotD
{
    public class Options
    {
        [Option('d', "debug", Default = false, HelpText = "Start Debugger.")]
        public bool StartDebugger { get; set; }

        [Option('s', "createStartupEntry", Default = false, HelpText = "Create scheduled task to start OotD at logon.")]
        public bool CreateStartupEntry { get; set; }

        [Option('r', "removeStartupEntry", Default = false, HelpText = "Remove scheduled task to start OotD at logon.")]
        public bool RemoveStartupEntry { get; set; }
    }
}
