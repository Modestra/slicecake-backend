namespace Note.Domain;

public class ShortUserDto
{
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