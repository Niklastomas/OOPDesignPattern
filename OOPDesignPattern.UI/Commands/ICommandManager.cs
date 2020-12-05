using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPDesignPattern.UI.Commands
{
    public interface ICommandManager
    {
        void Invoke(ICommand command);

        void Undo();

        void Redo();
    }
}