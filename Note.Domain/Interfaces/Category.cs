using System.ComponentModel.DataAnnotations;

namespace Domain.Interfaces;

public class Category
{
    [Key]
    public Guid Id { get; set; }
    /// <summary>
    /// Название категории
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Описание категории
    /// </summary>
    public string Decription { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public ImageDto Image { get; set; }
}