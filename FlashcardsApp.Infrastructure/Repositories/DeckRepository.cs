using FlashcardsApp.Core.Entities;
using FlashcardsApp.Core.Interfaces;
using FlashcardsApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlashcardsApp.Infrastructure.Repositories
{
    public class DeckRepository : Repository<Deck>, IDeckRepository
    {
        public DeckRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Deck?> GetDeckWithFlashcardsAsync(int id)
        {
            return await _context.Decks
                .Include(d => d.Flashcards)
                .FirstOrDefaultAsync(d => d.Id == id);
        }
    }
}
