using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BITCOIN_SIMULATOR_TAB_.ViewModel.Commands
{
    class NextCommand : ICommand
    {
        UpbitVM VM { get; set; }

        public NextCommand(UpbitVM vm)
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
            VM.Date++;

            if (UserVM.Usr.Btc > 0)
            {
                UserVM.Usr.BtcRate = (VM.UpbitDataToShow1.Trade_price - UserVM.Usr.BtcPrice) / UserVM.Usr.BtcPrice;
            }
            if (UserVM.Usr.Eth > 0)
            {
                UserVM.Usr.EthRate = (VM.UpbitDataToShow2.Trade_price - UserVM.Usr.EthPrice) / UserVM.Usr.EthPrice;
            }
            if (UserVM.Usr.Xrp > 0)
            {
                UserVM.Usr.XrpRate = (VM.UpbitDataToShow3.Trade_price - UserVM.Usr.XrpPrice) / UserVM.Usr.XrpPrice;
            }
            if (UserVM.Usr.Dot > 0)
            {
                UserVM.Usr.DotRate = (VM.UpbitDataToShow4.Trade_price - UserVM.Usr.DotPrice) / UserVM.Usr.DotPrice;
            }
            if (UserVM.Usr.Doge > 0)
            {
                UserVM.Usr.DogeRate = (VM.UpbitDataToShow5.Trade_price - UserVM.Usr.DogePrice) / UserVM.Usr.DogePrice;
            }

            UserVM.Usr.PfCoin = (UserVM.Usr.Btc + (UserVM.Usr.Btc * UserVM.Usr.BtcRate)) + (UserVM.Usr.Eth + (UserVM.Usr.Eth * UserVM.Usr.EthRate)) + 
                (UserVM.Usr.Xrp + (UserVM.Usr.Xrp * UserVM.Usr.XrpRate)) + (UserVM.Usr.Dot + (UserVM.Usr.Dot * UserVM.Usr.DotRate))+ (UserVM.Usr.Doge + (UserVM.Usr.Doge * UserVM.Usr.DogeRate));

            UserVM.Usr.TotalMoney = UserVM.Usr.UserMoney + UserVM.Usr.PfCoin;
            UserVM.Usr.PfMoney = UserVM.Usr.PfCoin - UserVM.Usr.TotalCoin;

            if (UserVM.Usr.TotalCoin == 0)
            {
                UserVM.Usr.PfRate = 0;
            }
            else
            {
                UserVM.Usr.PfRate = (UserVM.Usr.PfCoin - UserVM.Usr.TotalCoin) / UserVM.Usr.TotalCoin;
            }
        }
    }
}
