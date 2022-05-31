using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using BITCOIN_SIMULATOR_TAB_.Model;

namespace BITCOIN_SIMULATOR_TAB_.ViewModel.Commands
{
    class BuyCommand : ICommand
    {
        string valueStr;
        double value;

        UserVM VM { get; set; }

        public BuyCommand(UserVM vm)
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
            valueStr = ((TextBox)parameter).Text as string;
            if (Double.TryParse(valueStr, out value))
            {
                if (value<=UserVM.Usr.UserMoney)
                {
                    if (UpbitVM.SelectedData.Market == "KRW-BTC")
                    {
                        if (UserVM.Usr.Btc == 0)
                        {
                            UserVM.Usr.BtcPrice = UpbitVM.SelectedData.Trade_price;
                        }
                        else
                        {
                            UserVM.Usr.BtcPrice = ((UserVM.Usr.Btc * UserVM.Usr.BtcPrice) + (UpbitVM.SelectedData.Trade_price * value)) / (UserVM.Usr.Btc + value);
                        }
                        UserVM.Usr.Btc += value;
                        UserVM.Usr.TotalCoin += value;
                        UserVM.Usr.UserMoney -= value;
                        UserVM.Usr.UserCoin = UserVM.Usr.Btc;
                    }
                    else if (UpbitVM.SelectedData.Market == "KRW-ETH")
                    {
                        if (UserVM.Usr.Eth == 0)
                        {
                            UserVM.Usr.EthPrice = UpbitVM.SelectedData.Trade_price;
                        }
                        else
                        {
                            UserVM.Usr.EthPrice = ((UserVM.Usr.Eth * UserVM.Usr.EthPrice) + (UpbitVM.SelectedData.Trade_price * value)) / (UserVM.Usr.Eth + value);
                        }
                        UserVM.Usr.Eth += value;
                        UserVM.Usr.TotalCoin += value;
                        UserVM.Usr.UserMoney -= value;
                        UserVM.Usr.UserCoin = UserVM.Usr.Eth;
                    }
                    else if (UpbitVM.SelectedData.Market == "KRW-XRP")
                    {
                        if (UserVM.Usr.Eth == 0)
                        {
                            UserVM.Usr.XrpPrice = UpbitVM.SelectedData.Trade_price;
                        }
                        else
                        {
                            UserVM.Usr.XrpPrice = ((UserVM.Usr.Xrp * UserVM.Usr.XrpPrice) + (UpbitVM.SelectedData.Trade_price * value)) / (UserVM.Usr.Xrp + value);
                        }
                        UserVM.Usr.Xrp += value;
                        UserVM.Usr.TotalCoin += value;
                        UserVM.Usr.UserMoney -= value;
                        UserVM.Usr.UserCoin = UserVM.Usr.Xrp;
                    }
                    else if (UpbitVM.SelectedData.Market == "KRW-DOT")
                    {
                        if (UserVM.Usr.Dot == 0)
                        {
                            UserVM.Usr.DotPrice = UpbitVM.SelectedData.Trade_price;
                        }
                        else
                        {
                            UserVM.Usr.DotPrice = ((UserVM.Usr.Dot * UserVM.Usr.DotPrice) + (UpbitVM.SelectedData.Trade_price * value)) / (UserVM.Usr.Dot + value);
                        }
                        UserVM.Usr.Dot += value;
                        UserVM.Usr.TotalCoin += value;
                        UserVM.Usr.UserMoney -= value;
                        UserVM.Usr.UserCoin = UserVM.Usr.Dot;
                    }
                    else if (UpbitVM.SelectedData.Market == "KRW-DOGE")
                    {
                        if (UserVM.Usr.Doge == 0)
                        {
                            UserVM.Usr.DogePrice = UpbitVM.SelectedData.Trade_price;
                        }
                        else
                        {
                            UserVM.Usr.DogePrice = ((UserVM.Usr.Doge * UserVM.Usr.DogePrice) + (UpbitVM.SelectedData.Trade_price * value)) / (UserVM.Usr.Doge + value);
                        }
                        UserVM.Usr.Doge += value;
                        UserVM.Usr.TotalCoin += value;
                        UserVM.Usr.UserMoney -= value;
                        UserVM.Usr.UserCoin = UserVM.Usr.Doge;
                    }
                }
                else
                {
                    MessageBox.Show("주문가능한 자산이 부족합니다.");
                }
            }
            else
            {
                MessageBox.Show("잘 못 입력하셨습니다.");
            }
        }
    }
}
