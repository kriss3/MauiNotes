using MauiNotes.Api.Models;

namespace MauiNotes.Api.Repositories;

public interface INoteRepository
{
	Task<List<Note>> GetAllAsync();
	Task<Note?> GetByIdAsync(int id);
	Task<Note> AddAsync(Note note);
	Task<Note?> UpdateAsync(Note note);
	Task<bool> DeleteAsync(int id);
}
