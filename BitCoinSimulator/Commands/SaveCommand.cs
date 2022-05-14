using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BitCoinSimulator.Commands
{
    class SaveCommand : ICommand
    {
        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        bool ICommand.CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        void ICommand.Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
