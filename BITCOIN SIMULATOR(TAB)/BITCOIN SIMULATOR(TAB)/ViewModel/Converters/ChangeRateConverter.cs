using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BITCOIN_SIMULATOR_TAB_.ViewModel.Converters
{
    class ChangeRateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double CRValue = (double)value;
            if (CRValue > 0)
            {
                return "+" + Math.Round(CRValue * 100, 2) + "%";
            }
            else if (CRValue == 0)
            {
                return 0 + "%";
            }
            else
            {
                return Math.Round(CRValue * 100, 2) + "%";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "";
        }
    }
}
