using System.ComponentModel.DataAnnotations;

namespace Note.Domain;

public class Notes
{
    [Key]
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public int Price { get; set; }
    
    
}