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

            //loopa tills vi får en giltig inmatning
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("\nenter the amounts of pins to play with: ");
                    int setUp = Convert.ToInt32(Console.ReadLine());

                    if (setUp > 0)
                    {
                        NoPins = setUp;
                        Console.WriteLine($"amount of pins added: {NoPins}");
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("\namount needs to be more than 0");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("error: only enter numbers");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //ta stickor från "bordet"
        public void TakePins(int takePins)
        {
            if (takePins < 1 || takePins > 2)
            {
                return;
            }

            if (NoPins < takePins)
            {
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