namespace MauiNotes.Api.Dtos;

public sealed class NoteDto
{
	public int Id { get; init; }
	public string Title { get; init; } = string.Empty;
	public string Content { get; init; } = string.Empty;
}
