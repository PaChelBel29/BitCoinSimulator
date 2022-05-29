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
    class SetTheNameCommand : ICommand
    {
        public PlayerViewModel PV { get; set; }
        
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            TextBox text = parameter as TextBox;
            Properties.Save_Data.Default.username = text.Text;
            MessageBox.Show("아! 당신의 이름은" + text.Text + "였죠. 까먹고 있었어요...\n아무튼 당신은 한강에 몸을 던졌고...  점점 의식을 잃어갔습니다...");
            Page page = new Tutorial_Page_3();
            Application.Current.MainWindow.Content = page;
        } 
    }
}
