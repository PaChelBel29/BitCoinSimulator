﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BitCoinSimulator.ViewModel.Commands
{
    class Page_3_To_Game_Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Properties.Save_Data.Default.balance += 100000000;
            Properties.Save_Data.Default.is_Saved = true;
            MessageBox.Show("와 저인간은 누구길래... 이렇게 막무가내일까요???");
            MessageBox.Show("이제 본 게임 들어가는데 주식이랑 비트코인은 해보셨죠?");
            MessageBox.Show("안해보셨다면 음... 우리 디자이너가 천재니까 금방 알 수 있을거에요! 화이팅!!");
            //    //Page Maingame = new Main();
            //    //Application.Current.MainWindow.Content = Maingame;
        }
    }
}
