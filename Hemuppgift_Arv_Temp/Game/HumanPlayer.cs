namespace Hemuppgift_Arv_Temp.Game
{
    public class HumanPlayer : Player
    {
        //tilldela namn till människospelaren
        public HumanPlayer(string userId) : base(userId)
        {
            Console.Write("enter name: ");
            UserId = Console.ReadLine();
        }

        //människospelarens tur att ta välja antal pinnar 
        public override int TakePins(Board board)
        {
            bool validInput = false;

            //loopa tills vi får en giltig inmatning
            while (!validInput)
            {
                Console.Write($"\n{UserId}'s turn\ntake 1 or 2 pins: ");
                try
                {
                    int pinsTaken = Convert.ToInt32(Console.ReadLine());

                    //kontrollera om inmatningen är giltig
                    if (pinsTaken < 1 || pinsTaken > 2)
                    {
                        Console.WriteLine("error: can only take 1 or 2 pins");
                        continue;
                    }

                    Console.WriteLine($"\npins taken: {pinsTaken}");

                    //metoden för att ta stickor
                    board.TakePins(pinsTaken);

                    //avsluta loopen om giltig inmatning
                    validInput = true;

                    if (board.NoPins <= -1)
                    {
                        Console.WriteLine($"\n{UserId} wins!");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("error: only enter numbers.");
                    Console.WriteLine($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }

            //returnera nya antalet stickor
            return board.NoPins;
        }
    }
}