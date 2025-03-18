using FlashcardsApp.Core.Entities;

namespace FlashcardsApp.Core.Interfaces
{
    public interface IFlashcardRepository : IRepository<Flashcard>
    {
        Task<IEnumerable<Flashcard>> GetFlashcardsByDeckIdAsync(int deckId);
    }
}
