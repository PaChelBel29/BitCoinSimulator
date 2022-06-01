using BITCOIN_SIMULATOR_TAB_.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
//201911907 CSE Div. 조훈희

namespace BITCOIN_SIMULATOR_TAB_.ViewModel.Commands
{
    class StartCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            if (Properties.Save_Data.Default.is_Saved)
            {
                Window Maingame = new TabWindow();
                Application.Current.MainWindow.Content = Maingame;
            }
            else
            {
                Page page = new Tutorial_Page_1();
                page.Title = "Tutorial";
                Application.Current.MainWindow.Content = page;
            }

        }
    }
}
