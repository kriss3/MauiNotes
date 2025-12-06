using MauiNotes.Api.Models;

namespace MauiNotes.Api.Repositories;

public class InMemoryNoteRepository : INoteRepository
{
	private readonly List<Note> _notes =
    [
        new Note { Id = 1, Title = "Welcome to MAUI", Content = "This note comes from the Web API (in-memory)." },
		new Note { Id = 2, Title = "Second note", Content = "You can create, update, and delete notes here." }
	];

	private int _nextId = 3;

	public Task<List<Note>> GetAllAsync()
	{
		// Return a copy to avoid external mutation of internal list
		return Task.FromResult(_notes.ToList());
	}


	public Task<Note> AddAsync(Note note)
    {
		note.Id = _nextId++;
		_notes.Add(note);
		return Task.FromResult(note);
	}

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Note?> GetByIdAsync(int id)
    {
		var note = _notes.FirstOrDefault(n => n.Id == id);
		return Task.FromResult(note);
	}

    public Task<Note?> UpdateAsync(Note note)
    {
        throw new NotImplementedException();
    }
}
