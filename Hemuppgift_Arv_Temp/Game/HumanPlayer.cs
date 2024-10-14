namespace Hemuppgift_Arv_Temp.Game
{
    public class HumanPlayer : Player
    {
        //constructor
        public HumanPlayer(string userId) : base(userId)
        {
            UserId = Console.ReadLine();
        }

        public override int TakePins(Board board)
        {
            //välj antal pinnar att ta
            Console.Write("take 1 or 2 pins: ");
            int pinsToTake = Convert.ToInt32(Console.ReadLine());

            //skickar värdet till TakePins(board)
            board.TakePins(pinsToTake);

            //returnerar antalet stickor som finns kvar i spelet
            return board.NoPins;
        }
    }
}