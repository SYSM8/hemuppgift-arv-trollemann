using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        //property
        private string userId;
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        //constructor
        public Player(string userId)
        {
            UserId = userId;
        }

        //method
        //returnerar spelarens namn
        public string GetUserId()
        {
            return userId;
        }

        //abstract method
        //ärver från underklasserna HumanPlayer och ComputerPlayer
        public abstract int TakePins (Board board);
    }
}
