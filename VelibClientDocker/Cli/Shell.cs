﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClientDotNetCore.Cli.Commands;

namespace VelibClientDotNetCore.Cli
{
    public class Shell
    {
        private string prompt;
        private CommandLauncher launcher;

        public Shell(string prompt)
        {
            this.prompt = prompt;
            this.launcher = new CommandLauncher();
            launcher.AddCommand(new Help());
            launcher.AddCommand(new ListStations());
            launcher.AddCommand(new Quit());
            launcher.AddCommand(new StationBikes());
        }

        public void Execute()
        {
            while (true)
            {
                Console.Write(prompt);
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length > 0)
                {
                    //sends input information to the command launcher
                    launcher.Execute(input);
                }
            }
        }
    }
}
