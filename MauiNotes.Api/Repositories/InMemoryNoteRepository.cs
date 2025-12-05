using MauiNotes.Api.Models;

namespace MauiNotes.Api.Repositories;

public class InMemoryNoteRepository : INoteRepository
{
	private readonly List<Note> _notes =
    [
        new Note { Id = 1, Title = "Welcome to MAUI", Content = "This note comes from the Web API (in-memory)." },
		new Note { Id = 2, Title = "Second note", Content = "You can create, update, and delete notes here." }
	];

	public Task<Note> AddAsync(Note note)
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
