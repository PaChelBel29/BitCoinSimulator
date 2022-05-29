using BitCoinSimulator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BitCoinSimulator.ViewModel.Commands
{
    class Page_1_To_2_Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Page page = new Tutorial_Page_2();
            page.Title = "Tutorial";
            Application.Current.MainWindow.Content = page;
        }
    }
}
