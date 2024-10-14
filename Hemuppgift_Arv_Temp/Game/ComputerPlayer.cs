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
        //tilldela namn till npc
        public ComputerPlayer(string userId) : base(userId)
        {
            Console.Write("enter npc's name: ");
            UserId = Console.ReadLine();
        }

        //npc tur att ta pinnar
        public override int TakePins(Board board)
        {
            Random random = new Random();
            int pinsTaken = random.Next(1, 3);

            Console.WriteLine($"\n{UserId} turn\n\npins taken: {pinsTaken}");
            
            //skickar värdet till TakePins(board)
            board.TakePins(pinsTaken);

            //returnerar antalet stickor som finns kvar i spelet
            return board.NoPins;
        }
    }
}
