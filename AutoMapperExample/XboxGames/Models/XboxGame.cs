namespace XboxGames.Models
{
    public sealed class XboxGame : Game
    {
        public bool IsBackwardCompatible { get; set; }
        public bool IsKinectRequired { get; set; }
    }
}
