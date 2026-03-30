namespace XboxGames.Models
{
    public class XboxGame : Game
    {
        public bool IsBackwardCompatible { get; set; }
        public bool IsKineticRequired { get; set; }
    }
}
