using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClientDotNetCore.Cli.Commands;

namespace VelibClientDotNetCore.Cli
{
    /**
     * Executes a command corresponding to user input.
     */
    class CommandLauncher
    {
        private Dictionary<string, Command> commands;

        public CommandLauncher()
        {
            commands = new Dictionary<string, Command>();
        }

        public void AddCommand(Command command)
        {
            commands.Add(command.Name, command);
        }

        public void Execute(params string[] input)
        {
            //separation of command name and command arguments
            string commandName = input[0];
            string[] args = new string[input.Length - 1];
            if (args.Length > 0)
            {
                Array.Copy(input, 1, args, 0, input.Length - 1);
            }

            //executing the command if it exists…
            if (commands.ContainsKey(commandName))
            {
                commands[commandName].Execute(args);
            }
            else
            {
                throw new NotSupportedException("The method " + commandName + " doesn't exist.");
            }
        }
    }
}
