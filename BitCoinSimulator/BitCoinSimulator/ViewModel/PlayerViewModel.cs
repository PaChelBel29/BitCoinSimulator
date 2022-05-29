using BitCoinSimulator.Model;
using BitCoinSimulator.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCoinSimulator.ViewModel
{
    class PlayerViewModel
    {
        public PlayerData PlayerDataToShow { get; set; }
        public SetTheNameCommand setNameCommand { get; set; }
        public PlayerViewModel()
        {
            PlayerDataToShow = new PlayerData();
        }
    }
}
