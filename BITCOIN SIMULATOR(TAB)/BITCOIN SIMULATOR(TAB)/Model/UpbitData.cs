using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITCOIN_SIMULATOR_TAB_.Model
{
    public class UpbitData : INotifyPropertyChanged
    {
        private string market;

        public string Market
        {
            get { return market; }
            set { market = value; OnPropertyChanged("Market"); }
        }

        private DateTime candel_date_time_utc;

        public DateTime Candel_date_time_utc
        {
            get { return candel_date_time_utc; }
            set { candel_date_time_utc = value; OnPropertyChanged("Candle_date_time_utc"); }
        }

        private DateTime candel_date_time_kst;

        public DateTime Candel_date_time_kst
        {
            get { return candel_date_time_kst; }
            set { candel_date_time_kst = value; OnPropertyChanged("Candle_date-time_kst"); }
        }

        private double trade_price;

        public double Trade_price
        {
            get { return trade_price; }
            set { trade_price = value; OnPropertyChanged("Trade_price"); }
        }

        private double prev_closing_price;

        public double Prev_closing_price
        {
            get { return prev_closing_price; }
            set { prev_closing_price = value; OnPropertyChanged("Prev_closing_price"); }
        }

        private double change_price;

        public double Change_price
        {
            get { return change_price; }
            set { change_price = value; OnPropertyChanged("Change_price"); }
        }

        private double change_rate;

        public double Change_rate
        {
            get { return change_rate; }
            set { change_rate = value; OnPropertyChanged("Change_rate"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
