using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BITCOIN_SIMULATOR_TAB_.ViewModel.UserControls
{
    class TypingEffectButton : Button
    {


        public string script
        {
            get { return (string)GetValue(scriptProperty); }
            set { SetValue(scriptProperty, value); }
        }

        // Using a DependencyProperty as the backing store for script.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty scriptProperty =
            DependencyProperty.Register("script", typeof(string), typeof(TypingEffectButton),
                new PropertyMetadata(scriptoAsync));

        private static async void scriptoAsync(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            TypingEffectButton TEButton = source as TypingEffectButton;
            string s = TEButton.script;
            TEButton.Content = "";
            foreach (char ch in s)
            {
                TEButton.Content = TEButton.Content.ToString() + ch;
                await Task.Delay(5);//1second=1000
            }
        }
    }
}
