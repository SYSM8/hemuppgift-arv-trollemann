namespace Hemuppgift_Arv_Temp.Game
{
    public class ComputerPlayer : Player
    {

        bool difficultyLevel;

        //tilldela namn till npc
        public ComputerPlayer(string userId) : base(userId)
        {
            Console.Write("\nenter npc's name: ");
            UserId = Console.ReadLine();

            //välj svårighetsgrad
            bool validInput = false;
            while (!validInput)
            {
                Console.Write("\nSelect difficulty level\n1: easy\n2: hard\n\nlevel: ");
                {

                    try
                    {
                        int selectDifficulty = Convert.ToInt32(Console.ReadLine());

                        switch (selectDifficulty)
                        {
                            case 1:
                                difficultyLevel = false;
                                validInput = true;
                                break;

                            case 2:
                                difficultyLevel = true;
                                validInput = true;
                                break;

                            default:
                                break;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("error: only enter numbers");
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                }
            }
        }

        //npc tur att ta pinnar
        public override int TakePins(Board board)
        {
            int pinsTaken;

            //false för enkelt
            if (!difficultyLevel)
            {
                Random random = new Random();
                pinsTaken = random.Next(1, 3);
            }

            //true för svårt
            else
            {
                if (board.NoPins % 3 == 0)
                {
                    Random random = new Random();
                    pinsTaken = random.Next(1, 3);
                }
                else
                {
                    pinsTaken = board.NoPins % 3;
                }
            }

            //om enbart det finns 1 pinne kvar o man drar 2, autojustering
            if (pinsTaken > board.NoPins)
            {
                pinsTaken = board.NoPins;
            }

            Console.WriteLine($"\n{UserId}'s turn\n\npins taken: {pinsTaken}");

            //skickar värdet till TakePins(board)
            board.TakePins(pinsTaken);

            if (board.NoPins <= 0)
            {
                Console.WriteLine($"\n{UserId} wins! buh-bye!");
            }

            //returnerar antalet stickor som finns kvar i spelet
            return board.NoPins;
        }
    }
}