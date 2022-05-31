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
    class SellCommand : ICommand
    {
        string valueStr;
        double value;

        UserVM VM { get; set; }

        public SellCommand(UserVM vm)
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
                if (UpbitVM.SelectedData.Market == "KRW-BTC")
                {
                    if (value < UserVM.Usr.Btc)
                    {
                        UserVM.Usr.UserMoney += value + (UserVM.Usr.BtcRate * value);
                        UserVM.Usr.PfMoney -= UserVM.Usr.BtcRate * value;
                        UserVM.Usr.PfCoin -= value + (UserVM.Usr.BtcRate * value);
                        UserVM.Usr.Btc -= value;
                        UserVM.Usr.TotalCoin -= value;
                        UserVM.Usr.UserCoin -= value;
                        UserVM.Usr.PfRate = (UserVM.Usr.PfCoin - UserVM.Usr.TotalCoin) / UserVM.Usr.TotalCoin;
                    }
                    else if (value == UserVM.Usr.Btc)
                    {
                        UserVM.Usr.UserMoney += value + (UserVM.Usr.BtcRate * value);
                        UserVM.Usr.PfMoney -= UserVM.Usr.BtcRate * value;
                        UserVM.Usr.PfCoin -= value + (UserVM.Usr.BtcRate * value);
                        UserVM.Usr.Btc = 0;
                        UserVM.Usr.BtcPrice = 0;
                        UserVM.Usr.BtcRate = 0;
                        UserVM.Usr.TotalCoin -= value;
                        UserVM.Usr.UserCoin = 0;
                        UserVM.Usr.PfRate = (UserVM.Usr.PfCoin - UserVM.Usr.TotalCoin) / UserVM.Usr.TotalCoin;
                    }
                    else
                    {
                        MessageBox.Show("주문 가능한 자산이 부족합니다.");
                    }
                }

                if (UpbitVM.SelectedData.Market == "KRW-ETH")
                {
                    if (value < UserVM.Usr.Eth)
                    {
                        UserVM.Usr.UserMoney += value + (UserVM.Usr.EthRate * value);
                        UserVM.Usr.PfMoney -= UserVM.Usr.EthRate * value;
                        UserVM.Usr.PfCoin -= value + (UserVM.Usr.EthRate * value);
                        UserVM.Usr.Eth -= value;
                        UserVM.Usr.TotalCoin -= value;
                        UserVM.Usr.UserMoney += value;
                        UserVM.Usr.UserCoin -= value;
                        UserVM.Usr.PfRate = (UserVM.Usr.PfCoin - UserVM.Usr.TotalCoin) / UserVM.Usr.TotalCoin;
                    }
                    else if (value == UserVM.Usr.Eth)
                    {
                        UserVM.Usr.UserMoney += value + (UserVM.Usr.EthRate * value);
                        UserVM.Usr.PfMoney -= UserVM.Usr.EthRate * value;
                        UserVM.Usr.PfCoin -= value + (UserVM.Usr.EthRate * value);
                        UserVM.Usr.Eth = 0;
                        UserVM.Usr.EthPrice = 0;
                        UserVM.Usr.EthRate = 0;
                        UserVM.Usr.TotalCoin -= value;
                        UserVM.Usr.UserMoney += value;
                        UserVM.Usr.UserCoin = 0;
                        UserVM.Usr.PfRate = (UserVM.Usr.PfCoin - UserVM.Usr.TotalCoin) / UserVM.Usr.TotalCoin;
                    }
                    else
                    {
                        MessageBox.Show("주문 가능한 자산이 부족합니다.");
                    }
                }

                if (UpbitVM.SelectedData.Market == "KRW-XRP")
                {
                    if (value < UserVM.Usr.Xrp)
                    {
                        UserVM.Usr.UserMoney += value + (UserVM.Usr.XrpRate * value);
                        UserVM.Usr.PfMoney -= UserVM.Usr.XrpRate * value;
                        UserVM.Usr.PfCoin -= value + (UserVM.Usr.XrpRate * value);
                        UserVM.Usr.Xrp -= value;
                        UserVM.Usr.TotalCoin -= value;
                        UserVM.Usr.UserMoney += value;
                        UserVM.Usr.UserCoin -= value;
                        UserVM.Usr.PfRate = (UserVM.Usr.PfCoin - UserVM.Usr.TotalCoin) / UserVM.Usr.TotalCoin;
                    }
                    else if (value == UserVM.Usr.Xrp)
                    {
                        UserVM.Usr.UserMoney += value + (UserVM.Usr.XrpRate * value);
                        UserVM.Usr.PfMoney -= UserVM.Usr.XrpRate * value;
                        UserVM.Usr.PfCoin -= value + (UserVM.Usr.XrpRate * value);
                        UserVM.Usr.Xrp = 0;
                        UserVM.Usr.XrpPrice = 0;
                        UserVM.Usr.XrpRate = 0;
                        UserVM.Usr.TotalCoin -= value;
                        UserVM.Usr.UserMoney += value;
                        UserVM.Usr.UserCoin = 0;
                        UserVM.Usr.PfRate = (UserVM.Usr.PfCoin - UserVM.Usr.TotalCoin) / UserVM.Usr.TotalCoin;
                    }
                    else
                    {
                        MessageBox.Show("주문 가능한 자산이 부족합니다.");
                    }
                }

                if (UpbitVM.SelectedData.Market == "KRW-DOT")
                {
                    if (value < UserVM.Usr.Dot)
                    {
                        UserVM.Usr.UserMoney += value + (UserVM.Usr.DotRate * value);
                        UserVM.Usr.PfMoney -= UserVM.Usr.DotRate * value;
                        UserVM.Usr.PfCoin -= value + (UserVM.Usr.DotRate * value);
                        UserVM.Usr.Dot -= value;
                        UserVM.Usr.TotalCoin -= value;
                        UserVM.Usr.UserMoney += value;
                        UserVM.Usr.UserCoin -= value;
                        UserVM.Usr.PfRate = (UserVM.Usr.PfCoin - UserVM.Usr.TotalCoin) / UserVM.Usr.TotalCoin;
                    }
                    else if (value == UserVM.Usr.Dot)
                    {
                        UserVM.Usr.UserMoney += value + (UserVM.Usr.DotRate * value);
                        UserVM.Usr.PfMoney -= UserVM.Usr.DotRate * value;
                        UserVM.Usr.PfCoin -= value + (UserVM.Usr.DotRate * value);
                        UserVM.Usr.Dot = 0;
                        UserVM.Usr.DotPrice = 0;
                        UserVM.Usr.DotRate = 0;
                        UserVM.Usr.TotalCoin -= value;
                        UserVM.Usr.UserMoney += value;
                        UserVM.Usr.UserCoin = 0;
                        UserVM.Usr.PfRate = (UserVM.Usr.PfCoin - UserVM.Usr.TotalCoin) / UserVM.Usr.TotalCoin;
                    }
                    else
                    {
                        MessageBox.Show("주문 가능한 자산이 부족합니다.");
                    }
                }

                if (UpbitVM.SelectedData.Market == "KRW-DOGE")
                {
                    if (value < UserVM.Usr.Doge)
                    {
                        UserVM.Usr.UserMoney += value + (UserVM.Usr.DogeRate * value);
                        UserVM.Usr.PfMoney -= UserVM.Usr.DogeRate * value;
                        UserVM.Usr.PfCoin -= value + (UserVM.Usr.DogeRate * value);
                        UserVM.Usr.Doge -= value;
                        UserVM.Usr.TotalCoin -= value;
                        UserVM.Usr.UserMoney += value;
                        UserVM.Usr.UserCoin -= value;
                        UserVM.Usr.PfRate = (UserVM.Usr.PfCoin - UserVM.Usr.TotalCoin) / UserVM.Usr.TotalCoin;
                    }
                    else if (value == UserVM.Usr.Doge)
                    {
                        UserVM.Usr.UserMoney += value + (UserVM.Usr.DogeRate * value);
                        UserVM.Usr.PfMoney -= UserVM.Usr.DogeRate * value;
                        UserVM.Usr.PfCoin -= value + (UserVM.Usr.DogeRate * value);
                        UserVM.Usr.Doge = 0;
                        UserVM.Usr.DogePrice = 0;
                        UserVM.Usr.DogeRate = 0;
                        UserVM.Usr.TotalCoin -= value;
                        UserVM.Usr.UserMoney += value;
                        UserVM.Usr.UserCoin = 0;
                        UserVM.Usr.PfRate = (UserVM.Usr.PfCoin - UserVM.Usr.TotalCoin) / UserVM.Usr.TotalCoin;
                    }
                    else
                    {
                        MessageBox.Show("주문 가능한 자산이 부족합니다.");
                    }
                }
            }

            else
            {
                MessageBox.Show("잘 못 입력하셨습니다.");
            }
        }
    }
}
