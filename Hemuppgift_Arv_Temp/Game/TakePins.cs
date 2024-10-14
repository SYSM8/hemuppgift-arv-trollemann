namespace Hemuppgift_Arv_Temp.Game
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            Board board = new Board();

            // Fråga användaren hur många stickor som ska finnas på bordet
            Console.Write("welcome!\ninput amount of sticks to play with: ");
            int setUp = Convert.ToInt32(Console.ReadLine());

            board.SetUp(setUp);
        }
    }
}
    