using FlashcardsApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlashcardsApp.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Deck> Decks { get; set; } = null!;
        public DbSet<Flashcard> Flashcards { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Deck>()
                .HasMany(d => d.Flashcards)
                .WithOne(f => f.Deck)
                .HasForeignKey(f => f.DeckId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
