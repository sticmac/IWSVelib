using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClient.Cli.Commands;

namespace VelibClient.Cli
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
                    //the first element of input is the name of the command
                    //the following ones are the command arguments
                    launcher.Execute(input);
                }
            }
        }
    }
}
