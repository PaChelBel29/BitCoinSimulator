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
    class StartCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (!Properties.Save_Data.Default.is_Saved)
            {
                return true;
                //return false;
                // 튜토리얼 스타트~
            }
            return true;
        }

        public void Execute(object parameter)
        {
            Page Tuto = new Tutorial_Page();
            Application.Current.MainWindow.Content = Tuto;

            //그냥 게임 스타트~
        }
    }
}
