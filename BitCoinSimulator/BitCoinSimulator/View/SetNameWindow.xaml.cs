using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BitCoinSimulator.View
{
    /// <summary>
    /// SetNameWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SetNameWindow : Window
    {
        public SetNameWindow()
        {
            InitializeComponent();
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            Name = txt.Text;
            Properties.Save_Data.Default.username = txt.Text;
            Window.GetWindow(this).Close();
        }
    }
}
