using FlashcardsApp.Core.Entities;
using FlashcardsApp.Core.Interfaces;
using FlashcardsApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlashcardsApp.Infrastructure.Repositories
{
    public class FlashcardRepository : Repository<Flashcard>, IFlashcardRepository
    {
        public FlashcardRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Flashcard>> GetFlashcardsByDeckIdAsync(int deckId)
        {
            return await _context.Flashcards
                .Where(f => f.DeckId == deckId)
                .ToListAsync();
        }
    }
}
