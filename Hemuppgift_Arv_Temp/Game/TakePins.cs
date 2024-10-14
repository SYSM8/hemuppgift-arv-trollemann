namespace Hemuppgift_Arv_Temp.Game
{
    internal class TakePins
    {
        public static void Main(string[] args)
        {
            //skapa ett bräde med ett antal stickor
            Board board = new Board();

            //den mänskliga spelaren
            HumanPlayer humanPlayer = new HumanPlayer("");

            //datorspelaren "einstein"
            ComputerPlayer computerPlayer = new ComputerPlayer("");

            //tillkallar metoden setUp
            board.SetUp();

            //bestämmer vem som börjar
            bool humanPlayerTurn = true;

            //loop tills nån vinner
            while (board.NoPins > 0)
            {
                if (humanPlayerTurn)
                {
                    humanPlayer.TakePins(board);
                }
                else
                {
                    computerPlayer.TakePins(board);
                }

                //bytar vems tur att ta
                humanPlayerTurn = !humanPlayerTurn;
            }
        }
    }
}