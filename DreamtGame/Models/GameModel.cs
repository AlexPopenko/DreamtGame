namespace DreamtGame.Models
{
    public class GameModel
    {
        public int ScoreP1 { get; set; } = 0;
        public int ScoreP2 { get; set; } = 0;

        public string Turn { get; set; } = "Player 1's Turn";
        public string? UserenameP1 { get; set; }
        public string? UserenameP2 { get; set; }
        public bool ColorBlind { get; set; }

    }
}
