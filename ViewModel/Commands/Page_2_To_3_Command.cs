using BITCOIN_SIMULATOR_TAB_.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BITCOIN_SIMULATOR_TAB_.ViewModel.Commands
{
    class Page_2_To_3_Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Page page = new SetNamePage();
            page.Title = "Tutorial";
            Application.Current.MainWindow.Content = page;
        }
    }
}
