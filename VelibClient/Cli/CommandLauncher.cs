using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClient.Cli.Commands;

namespace VelibClient.Cli
{
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

        public void Execute(string commandName)
        {
            if (commands.ContainsKey(commandName))
            {
                commands[commandName].Execute();
            }
            else
            {
                throw new NotSupportedException("The method " + commandName + " doesn't exist.");
            }
        }
    }
}
