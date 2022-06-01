using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BITCOIN_SIMULATOR_TAB_.ViewModel.Converters
{
    class CoinPriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double CPValue = (double)value;
            if (CPValue > 0)
            {
                return string.Format("{0:#,0}", Math.Round(CPValue, 0)); 
            }
            else
            {
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "";
        }
    }
}
