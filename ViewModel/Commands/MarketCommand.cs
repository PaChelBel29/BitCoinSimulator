using BITCOIN_SIMULATOR_TAB_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace BITCOIN_SIMULATOR_TAB_.ViewModel.Commands
{
    class MarketCommand : ICommand
    {
        string marketName;

        UpbitVM VM { get; set; }

        public MarketCommand(UpbitVM vm)
        {
            VM = vm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            marketName = ((Button)parameter).Content as string;

            if (marketName == "비트코인 (BTC)")
            {
                VM.MarketName = "KRW-BTC";
                UserVM.Usr.UserCoin = UserVM.Usr.Btc;
            }
            else if (marketName == "이더리움 (ETH)")
            {
                VM.MarketName = "KRW-ETH";
                UserVM.Usr.UserCoin = UserVM.Usr.Eth;
            }
            else if (marketName == "리플 (XRP)")
            {
                VM.MarketName = "KRW-XRP";
                UserVM.Usr.UserCoin = UserVM.Usr.Xrp;
            }
            else if (marketName == "폴카닷 (DOT)")
            {
                VM.MarketName = "KRW-DOT";
                UserVM.Usr.UserCoin = UserVM.Usr.Dot;
            }
            else if (marketName == "도지 (DOGE)")
            {
                VM.MarketName = "KRW-DOGE";
                UserVM.Usr.UserCoin = UserVM.Usr.Doge;
            }
            else
            {
                return;
            }
        }
    }
}
