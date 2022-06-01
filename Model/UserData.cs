using BITCOIN_SIMULATOR_TAB_.ViewModel;
using BITCOIN_SIMULATOR_TAB_.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITCOIN_SIMULATOR_TAB_.Model
{
    class UserData : INotifyPropertyChanged
    {
        private double userCoin; // 선택한 코인

        public double UserCoin 
        {
            get { return userCoin; }
            set { userCoin = value; NotifyPropertyChanged("UserCoin"); }
        }

        private double totalCoin; // 총 코인 보유량

        public double TotalCoin
        {
            get { return totalCoin; }
            set { totalCoin = value; NotifyPropertyChanged("TotalCoin"); }
        }

        private double pfCoin; // 코인 손수익 

        public double PfCoin
        {
            get { return pfCoin; }
            set { pfCoin = value; NotifyPropertyChanged("PfCoin"); }
        }

        private double pfMoney; // 총 평가 자산

        public double PfMoney
        {
            get { return pfMoney; }
            set { pfMoney = value; NotifyPropertyChanged("PfMoney"); }
        }

        private double pfRate; // 총 손수익률

        public double PfRate
        {
            get { return pfRate; }
            set { pfRate = value; NotifyPropertyChanged("PfRate"); }
        }

        private double totalMoney; // 코인 손수익 + 자산 

        public double TotalMoney
        {
            get { return totalMoney; }
            set { totalMoney = value; NotifyPropertyChanged("TotalMoney"); }
        }

        private double userMoney; // 매수가능 자산

        public double UserMoney
        {
            get { return userMoney; }
            set { userMoney = value; NotifyPropertyChanged("UserMoney"); }
        }

        private double btc; //비트코인 보유랑

        public double Btc
        {
            get { return btc; }
            set { btc = value; NotifyPropertyChanged("Btc"); }
        }

        private double eth; // 이더리움 보유량

        public double Eth
        {
            get { return eth; }
            set { eth = value; NotifyPropertyChanged("Eth"); }
        }

        private double xrp; // 리플 보유량

        public double Xrp
        {
            get { return xrp; }
            set { xrp = value; NotifyPropertyChanged("Xrp"); }
        }

        private double dot; // 폴카닷 보유량

        public double Dot
        {
            get { return dot; }
            set { dot = value; NotifyPropertyChanged("Dot"); }
        }

        private double doge; // 도지 보유량

        public double Doge
        {
            get { return doge; }
            set { doge = value; NotifyPropertyChanged("Doge"); }
        }

        private double btcPrice; // 비트코인 평단가

        public double BtcPrice
        {
            get { return btcPrice; }
            set { btcPrice = value; NotifyPropertyChanged("BtcPrice"); }
        }

        private double ethPrice; // 이더리움 평단가

        public double EthPrice
        {
            get { return ethPrice; }
            set { ethPrice = value; NotifyPropertyChanged("EthPrice"); }
        }

        private double xrpPrice; // 리플 평단가

        public double XrpPrice
        {
            get { return xrpPrice; }
            set { xrpPrice = value; NotifyPropertyChanged("XrpPrice"); }
        }

        private double dotPrice; // 폴카닷 평단가

        public double DotPrice
        {
            get { return dotPrice; }
            set { dotPrice = value; NotifyPropertyChanged("DotPrice"); }
        }

        private double dogePrice; // 도지 평단가

        public double DogePrice
        {
            get { return dogePrice; }
            set { dogePrice = value; NotifyPropertyChanged("DogePrice"); }
        }

        private double btcRate; // 비트코인 수익률

        public double BtcRate
        {
            get { return btcRate; }
            set { btcRate = value; NotifyPropertyChanged("BtcRate"); }
        }

        private double ethRate; // 이더리움 수익률

        public double EthRate
        {
            get { return ethRate; }
            set { ethRate = value; NotifyPropertyChanged("EthRate"); }
        }

        private double xrpRate; // 리플 수익률

        public double XrpRate
        {
            get { return xrpRate; }
            set { xrpRate = value; NotifyPropertyChanged("XrpRate"); }
        }

        private double dotRate; // 폴카닷 수익률

        public double DotRate
        {
            get { return dotRate; }
            set { dotRate = value; NotifyPropertyChanged("DotRate"); }
        }

        private double dogeRate; // 도지 수익률

        public double DogeRate
        {
            get { return dogeRate; }
            set { dogeRate = value; NotifyPropertyChanged("DogeRate"); }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
