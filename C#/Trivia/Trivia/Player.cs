namespace UglyTrivia
{
    internal class Player
    {
        public Player(string playerName)
        {
            Name = playerName;
            Purses = 0;
            Places = 0;
            InPenaltyBox = false;
        }
        
        public string Name { get; private set; }

        public int Purses { get; private set; }

        public int Places { get; set; }

        public bool InPenaltyBox { get; set; }

        public void WinOnePurses ()
        {
            Purses ++;
        }

        public bool DidNotPlayerWin()
        {
            return Purses != 6;
        }
    }
}