using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlashcardsApp.Core.Entities
{
    public class Flashcard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Question { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Answer { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [ForeignKey("Deck")]
        public int DeckId { get; set; }

        public virtual Deck Deck { get; set; } = null!;
    }
}
