﻿using System.ComponentModel.DataAnnotations;

namespace FlashcardsApp.Core.Entities
{
    public class Deck
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Flashcard> Flashcards { get; set; } = new List<Flashcard>();
    }
}
