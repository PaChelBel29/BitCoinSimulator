using BITCOIN_SIMULATOR_TAB_.Model;
using BITCOIN_SIMULATOR_TAB_.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITCOIN_SIMULATOR_TAB_.ViewModel
{
    class UpbitVM
    {
        public NextCommand NextCommand { get; set; }
        public MarketCommand MarketCommand { get; set; }
        public UpbitData UpbitDataToShow1 { get; set; }
        public UpbitData UpbitDataToShow2 { get; set; }
        public UpbitData UpbitDataToShow3 { get; set; }
        public UpbitData UpbitDataToShow4 { get; set; }
        public UpbitData UpbitDataToShow5 { get; set; }
        public static UpbitData SelectedData { get; set; }

        private int date = 1;

        public int Date
        {
            get { return date; }
            set { date = value; SelectedDate = date.ToString("D2"); }
        }

        private string selectedDate = "01";

        public string SelectedDate
        {
            get { return selectedDate; }
            set { selectedDate = value; GetUpbit(); }
        }

        private string marketName;

        public string MarketName
        {
            get { return marketName; }
            set { marketName = value; GetUpbit(); }
        }


        public UpbitVM()
        {
            NextCommand = new NextCommand(this);
            MarketCommand = new MarketCommand(this);

            UpbitDataToShow1 = new UpbitData();
            var upbit1 = UpbitAPI.GetUpbitData("KRW-BTC", selectedDate);
            UpbitDataToShow1.Market = upbit1.Market;
            UpbitDataToShow1.Trade_price = upbit1.Trade_price;
            UpbitDataToShow1.Change_rate = upbit1.Change_rate;

            UpbitDataToShow2 = new UpbitData();
            var upbit2 = UpbitAPI.GetUpbitData("KRW-ETH", selectedDate);
            UpbitDataToShow2.Market = upbit2.Market;
            UpbitDataToShow2.Trade_price = upbit2.Trade_price;
            UpbitDataToShow2.Change_rate = upbit2.Change_rate;

            UpbitDataToShow3 = new UpbitData();
            var upbit3 = UpbitAPI.GetUpbitData("KRW-XRP", selectedDate);
            UpbitDataToShow3.Market = upbit3.Market;
            UpbitDataToShow3.Trade_price = upbit3.Trade_price;
            UpbitDataToShow3.Change_rate = upbit3.Change_rate;

            UpbitDataToShow4 = new UpbitData();
            var upbit4 = UpbitAPI.GetUpbitData("KRW-DOT", selectedDate);
            UpbitDataToShow4.Market = upbit4.Market;
            UpbitDataToShow4.Trade_price = upbit4.Trade_price;
            UpbitDataToShow4.Change_rate = upbit4.Change_rate;

            UpbitDataToShow5 = new UpbitData();
            var upbit5 = UpbitAPI.GetUpbitData("KRW-DOGE", selectedDate);
            UpbitDataToShow5.Market = upbit5.Market;
            UpbitDataToShow5.Trade_price = upbit5.Trade_price;
            UpbitDataToShow5.Change_rate = upbit5.Change_rate;

            SelectedData = new UpbitData();
        }

        public void GetUpbit()
        {
            var upbit1 = UpbitAPI.GetUpbitData("KRW-BTC", selectedDate);
            UpbitDataToShow1.Market = upbit1.Market;
            UpbitDataToShow1.Trade_price = upbit1.Trade_price;
            UpbitDataToShow1.Change_rate = upbit1.Change_rate;

            var upbit2 = UpbitAPI.GetUpbitData("KRW-ETH", selectedDate);
            UpbitDataToShow2.Market = upbit2.Market;
            UpbitDataToShow2.Trade_price = upbit2.Trade_price;
            UpbitDataToShow2.Change_rate = upbit2.Change_rate;

            var upbit3 = UpbitAPI.GetUpbitData("KRW-XRP", selectedDate);
            UpbitDataToShow3.Market = upbit3.Market;
            UpbitDataToShow3.Trade_price = upbit3.Trade_price;
            UpbitDataToShow3.Change_rate = upbit3.Change_rate;

            var upbit4 = UpbitAPI.GetUpbitData("KRW-DOT", selectedDate);
            UpbitDataToShow4.Market = upbit4.Market;
            UpbitDataToShow4.Trade_price = upbit4.Trade_price;
            UpbitDataToShow4.Change_rate = upbit4.Change_rate;

            var upbit5 = UpbitAPI.GetUpbitData("KRW-DOGE", selectedDate);
            UpbitDataToShow5.Market = upbit5.Market;
            UpbitDataToShow5.Trade_price = upbit5.Trade_price;
            UpbitDataToShow5.Change_rate = upbit5.Change_rate;

            var upbit6 = UpbitAPI.GetUpbitData(marketName, selectedDate);
            SelectedData.Market = upbit6.Market;
            SelectedData.Trade_price = upbit6.Trade_price;
        }

    }
}
