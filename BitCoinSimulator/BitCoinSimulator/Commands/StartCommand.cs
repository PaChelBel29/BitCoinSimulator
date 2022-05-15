using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BitCoinSimulator.Commands
{
    class StartCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // if (/*is_saveddata_exist()*/)
            //{
            //참일때 그냥 게임 진행 하도록
            //}
            //else
            //{
            //    //튜토리얼 스타트하도록
            //}
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("아직 미구현입니다 >ㅁ-");
        }
    }
}
