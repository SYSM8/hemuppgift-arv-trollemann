using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string userId) : base(userId)
        {
            UserId = "Einstein";
        }
        public override int TakePins(Board board)
        {
            Random random = new Random();
            int pinsTaken = random.Next(1, 2);

            Console.WriteLine($"{UserId} has taken {pinsTaken} pins");
            
            //skickar värdet till TakePins(board)
            board.TakePins(pinsTaken);

            //returnerar antalet stickor som finns kvar i spelet
            return board.NoPins;
        }
    }
}
