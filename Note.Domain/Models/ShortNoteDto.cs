using System.ComponentModel.DataAnnotations;

namespace Note.Domain;

public class ShortNoteDto
{
    [Key]
    public Guid Id { get; set; }
}