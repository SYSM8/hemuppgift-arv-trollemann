namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        // property (egenskap/attribut)
        private int noPins;
        public int NoPins
        {
            get { return noPins; }
            set { noPins = value; }
        }

        // metod för att tilldela en vald mängd stickor till noPins
        public void SetUp(int setUp)
        {
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


        // metod för att ta stickor från "bordet"
        int takePins;
        public void TakePins(int takePins)
        {
            Console.Write("take 1 or 2 pins: ");
            takePins = Convert.ToInt32(Console.ReadLine());

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

            // minska antalet stickor i spelet
            NoPins -= takePins;
            GetNoPins();
        }

        public void GetNoPins()
        {
            Console.WriteLine($"amount of pins left: {NoPins}");
        }
    }
}