using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPDesignPattern.UI.Commands
{
    public class CommandManager : ICommandManager
    {
        private Stack<ICommand> commands = new Stack<ICommand>();
        private ICommand _command;

        public void Invoke(ICommand command)
        {
            commands.Push(command);
            command.Execute();
        }

        public void Undo()
        {
            if (commands.Count > 0)
            {
                _command = commands.Pop();
                _command.Undo();
            }
        }

        public void Redo()
        {
            if (_command != null)
            {
                commands.Push(_command);
                _command.Execute();
            }
            _command = null;
        }
    }
}