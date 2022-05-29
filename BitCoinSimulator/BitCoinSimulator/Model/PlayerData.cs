using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCoinSimulator.Model
{
    class PlayerData:INotifyPropertyChanged
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged("Username"); }
        }

        private int balance;

        public int Balacne
        {
            get { return balance; }
            set { balance = value; OnPropertyChanged("Balacne"); }
        }

        public PlayerData()
        {
            
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
