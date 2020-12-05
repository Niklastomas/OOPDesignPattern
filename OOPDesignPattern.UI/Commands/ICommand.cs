using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPDesignPattern.UI.Commands
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}