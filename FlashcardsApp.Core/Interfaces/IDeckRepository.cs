using FlashcardsApp.Core.Entities;

namespace FlashcardsApp.Core.Interfaces
{
    public interface IDeckRepository : IRepository<Deck>
    {
        Task<Deck> GetDeckWithFlashcardsAsync(int id);
    }
}
