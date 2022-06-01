using BITCOIN_SIMULATOR_TAB_.Model;
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
    class SetTheNameCommand : ICommand
    {
        public UserData userData { get; set; }

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
            TextBox text = parameter as TextBox;
            if (text.Text.Contains(" ") || text.Text.Contains('1') || text.Text.Contains('2') || text.Text.Contains('3')
                || text.Text.Contains('4') || text.Text.Contains('5') || text.Text.Contains('6')
                || text.Text.Contains('7') || text.Text.Contains('8') || text.Text.Contains('9') || text.Text.Contains('0'))
            {
                MessageBox.Show("이름에 공백이나 숫자가 들어가지는 않겠죠? 다시 입력해주세요!");
            }
            else
            {
                Properties.Save_Data.Default.username = text.Text;
                MessageBox.Show("아! 당신의 이름은" + text.Text + "... \n아무튼" + text.Text + "씨는 한강에 몸을 던졌고...  점점 의식이 희미해져갑니다");
                MessageBox.Show("....");
                MessageBox.Show("어라....?");
                Page page = new Tutorial_Page_3();
                Application.Current.MainWindow.Content = page;
            }
        }
    }
}
