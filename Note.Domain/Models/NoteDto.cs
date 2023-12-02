using System.ComponentModel.DataAnnotations;

namespace Note.Domain;

/// <summary>
/// Модель карточки 
/// </summary>
public class Notes
{
    [Key]
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public int Price { get; set; }
    
    
}