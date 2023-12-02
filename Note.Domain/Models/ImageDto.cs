namespace Domain.Interfaces;

public class ImageDto
{
    /// <summary>
    /// Название изображения
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Путь к изображению
    /// </summary>
    public string ImageUrl { get; set; }
}