using System.ComponentModel.DataAnnotations;

namespace Note.Domain;

public class ShortUserDto
{
    /// <summary>
    /// Id
    /// </summary>
    [Key]
    public Guid Id { get; set; }
    /// <summary>
    /// Email
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Логин
    /// </summary>
    public string Login { get; set; }
    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; }
    /// <summary>
    /// Возраст пользователя
    /// </summary>
    public int Age { get; set; }
    /// <summary>
    /// Пол пользователя
    /// </summary>
    public string Sex { get; set; }
}