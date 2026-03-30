namespace XboxGames.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        public int GenreFK { get; set; }
        public virtual Genre Genre { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}