﻿namespace NotesManager.Models.DataTransferObject;

public class NoteUpdateDto
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public int? CategoryId { get; set; }
}
