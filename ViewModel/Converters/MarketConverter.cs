using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BITCOIN_SIMULATOR_TAB_.ViewModel.Converters
{
    class MarketConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string marketName = (string)value;
            if (marketName == "KRW-XRP")
            {
                return "리플 (XRP)";
            }
            else if (marketName == "KRW-BTC")
            {
                return "비트코인 (BTC)";
            }
            else if (marketName == "KRW-ETH")
            {
                return "이더리움 (ETH)";
            }
            else if (marketName == "KRW-DOT")
            {
                return "폴카닷 (DOT)";
            }
            else if (marketName == "KRW-DOGE")
            {
                return "도지 (DOGE)";
            }
            else
            {
                return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "";
        }
    }
}
