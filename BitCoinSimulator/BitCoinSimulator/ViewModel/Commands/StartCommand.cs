using BitCoinSimulator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
//201911907 CSE Div. 조훈희

namespace BitCoinSimulator.ViewModel.Commands
{
    class StartCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            //if (Properties.Save_Data.Default.is_Saved)
            //{
            //    //Save 데이터에

            //    //Page Maingame = new Main();
            //    //Application.Current.MainWindow.Content = Maingame;
            //}
            //else
            //{
            Page page = new Tutorial_Page();
            page.Title = "Tutorial";
            Application.Current.MainWindow.Content = page;
            //}

        }
    }
}
