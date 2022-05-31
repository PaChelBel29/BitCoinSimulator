using BITCOIN_SIMULATOR_TAB_.Model;
using BITCOIN_SIMULATOR_TAB_.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITCOIN_SIMULATOR_TAB_.ViewModel
{
    class UserVM
    {
        public static UserData Usr { get; set; }
        public BuyCommand buyCom { get; set; }
        public SellCommand sellCom { get; set; }

        public UserVM()
        {
            Usr = new UserData();
            buyCom = new BuyCommand(this);
            sellCom = new SellCommand(this);
            Usr.UserMoney = 100000000;
        }
    }
}
