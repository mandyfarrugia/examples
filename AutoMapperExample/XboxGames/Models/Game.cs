using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XboxGames.Models
{
    public abstract class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public int DeveloperId { get; set; }

        [ForeignKey(nameof(DeveloperId))]
        public virtual Developer Developer { get; set; } = null!;

        [Required]
        public int GenreId { get; set; }

        [ForeignKey(nameof(GenreId))]
        public virtual Genre Genre { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateOnly ReleaseDate { get; set; }
    }
}