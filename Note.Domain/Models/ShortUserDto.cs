using System.ComponentModel.DataAnnotations;

namespace Note.Domain;

public class ShortUserDto
{
    /// <summary>
    /// Логин
    /// </summary>
    public string Login { get; set; }
    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; }
}