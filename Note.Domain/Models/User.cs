using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Note.Domain.Enums;

namespace Note.Domain;

public class User
{
    /// <summary>
    /// Id пользователя
    /// </summary>
    [Key]
    public Guid id { get; set; }
    /// <summary>
    /// Почта
    /// </summary>
    [Required(AllowEmptyStrings = true, ErrorMessage = "Email пусто или некорректно")]
    public string Email { get; set; }
    /// <summary>
    /// Логин
    /// </summary>
    [Required(AllowEmptyStrings = true, ErrorMessage = "Login пусто или некорректно")]
    public string Login { get; set; }
    /// <summary>
    /// Пароль
    /// </summary>
    [Required(AllowEmptyStrings = true, ErrorMessage = "Password пусто или некорректно")]
    public string Password { get; set; }
    /// <summary>
    /// Возраст пользователя
    /// </summary>
    public int Age { get; set; }
    /// <summary>
    /// Пол пользователя
    /// </summary>
    public string Sex { get; set; }
    /// <summary>
    /// Тип пользователя: Покупатель, продавец, администратор (скрытая)
    /// </summary>
    public UserTypes Profession { get; set; }
}