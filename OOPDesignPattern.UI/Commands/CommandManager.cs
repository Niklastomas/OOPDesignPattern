using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPDesignPattern.UI.Commands
{
    public class CommandManager : ICommandManager
    {
        private Stack<ICommand> commands = new Stack<ICommand>();
        private Stack<ICommand> undos = new Stack<ICommand>();

        public void Invoke(ICommand command)
        {
            commands.Push(command);
            command.Execute();
        }

        public void Undo()
        {
            if (commands.Count > 0)
            {
                var command = commands.Pop();
                command.Undo();
                undos.Push(command);
            }
        }

        public void Redo()
        {
            if (undos.Count > 0)
            {
                var command = undos.Pop();
                commands.Push(command);
                command.Execute();
            }
        }
    }
}