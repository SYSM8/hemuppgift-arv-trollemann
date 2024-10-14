namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        private int noPins;
        public int NoPins
        {
            get { return noPins; }
            set { noPins = value; }
        }

        //tilldela en vald mängd stickor till noPins
        public void SetUp()
        {
            Console.Write("enter the amounts of pins to play with: ");
            int setUp = Convert.ToInt32(Console.ReadLine());

            if (setUp > 0)
            {
                NoPins = setUp;
                Console.WriteLine($"amount of pins added: {NoPins}");
            }
            else
            {
                Console.WriteLine("\namount needs to be more than 0");
            }
        }


        //ta stickor från "bordet"
        public void TakePins(int takePins)
        {
            if (takePins < 1 || takePins > 2)
            {
                Console.WriteLine("can only take 1 or two pins");
                return;
            }

            if (NoPins < takePins)
            {
                Console.WriteLine("not enough pins left.");
                return;
            }

            //minska antalet stickor i spelet
            NoPins -= takePins;
            GetNoPins();
        }

        //skriver ut mängd pinnar kvar
        public void GetNoPins()
        {
            Console.WriteLine($"amount of pins left: {NoPins}");
        }
    }
}