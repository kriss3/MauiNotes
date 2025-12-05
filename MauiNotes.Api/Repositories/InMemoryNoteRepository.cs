using MauiNotes.Api.Models;

namespace MauiNotes.Api.Repositories;

public class InMemoryNoteRepository : INoteRepository
{
    public Task<Note> AddAsync(Note note)
    {
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Note>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Note?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Note?> UpdateAsync(Note note)
    {
        throw new NotImplementedException();
    }
}
