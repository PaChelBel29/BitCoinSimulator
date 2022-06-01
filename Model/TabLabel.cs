using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BITCOIN_SIMULATOR_TAB_.Model
{
    class TabLabel : Label
    {
        public object RateProperty
        {
            get { return (object)GetValue(RatePropertyProperty); }
            set { SetValue(RatePropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TempProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RatePropertyProperty =
            DependencyProperty.Register("RateProperty", typeof(object), typeof(TabLabel),
                new PropertyMetadata(false, OnIsRateChanged));

        private static void OnIsRateChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            TabLabel myLabel = (TabLabel)source;
            string rateStr = myLabel.Content as string;
            rateStr = rateStr.Replace("%", "");
            double rateDouble = Convert.ToDouble(rateStr);

            if (rateDouble < 0)
            {
                myLabel.Foreground = System.Windows.Media.Brushes.Blue;
            }
            else if (rateDouble == 0)
            {
                myLabel.Foreground = System.Windows.Media.Brushes.Black;
            }
            else
            {
                myLabel.Foreground = System.Windows.Media.Brushes.Red;
            }
        }
    }
}


