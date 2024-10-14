namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        //ärver från computer- eller humanplayer
        private string userId;
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        //tilldelar namn
        public Player(string userId)
        {
            UserId = userId;
        }

        //returnerar spelarens namn
        public string GetUserId()
        {
            return userId;
        }

        //ärver från underklasserna HumanPlayer och ComputerPlayer
        public abstract int TakePins(Board board);
    }
}
