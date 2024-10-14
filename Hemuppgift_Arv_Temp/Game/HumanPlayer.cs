namespace Hemuppgift_Arv_Temp.Game
{
    public class HumanPlayer : Player
    {
        //tilldela namn till människospelaren
        public HumanPlayer (string userId) : base(userId)
        {
            Console.Write("enter name: ");
            UserId = Console.ReadLine();
        }

        //människospelarens tur att ta välja antal pinnar 
        public override int TakePins(Board board)
        {
            //välj antal pinnar att ta
            Console.Write($"\n{UserId}'s turn\ntake 1 or 2 pins: ");
            int pinsTaken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\npins taken: {pinsTaken}");

            //skickar värdet till TakePins(board)
            board.TakePins(pinsTaken);

            //returnerar antalet stickor som finns kvar i spelet
            return board.NoPins;
        }
    }
}