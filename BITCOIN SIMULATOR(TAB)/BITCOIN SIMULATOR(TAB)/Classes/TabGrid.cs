using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BITCOIN_SIMULATOR_TAB_.Classes
{
    class TabGrid : Grid
    {

        public object aboutBackground
        {
            get { return (object)GetValue(aboutBackgroundProperty); }
            set { SetValue(aboutBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for aboutBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty aboutBackgroundProperty =
            DependencyProperty.Register("aboutBackground", typeof(object), typeof(TabGrid), 
                new PropertyMetadata(false, OnIsBackgroundChanged));

        private static void OnIsBackgroundChanged (DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            TabGrid myGrid = (TabGrid) source;

            TabItem tabItem = myGrid.aboutBackground as TabItem;

            if((String)tabItem.Header == "현재 자산")
            {
                myGrid.Background = System.Windows.Media.Brushes.PaleGreen;
            }
            else if ((String)tabItem.Header == "코인 시세")
            {
                myGrid.Background = System.Windows.Media.Brushes.Pink;
            }
            else if ((String)tabItem.Header == "코인 매매")
            {
                myGrid.Background = System.Windows.Media.Brushes.PaleTurquoise;
            }
            else if ((String)tabItem.Header == "보유 코인")
            {
                myGrid.Background = System.Windows.Media.Brushes.PaleGoldenrod;
            }
            else if ((String)tabItem.Header == "옵션")
            {
                myGrid.Background = System.Windows.Media.Brushes.Silver;
            }
        }

    }

}
