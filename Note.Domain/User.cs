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
    [Column]
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
    /// <summary>
    /// Тип пользователя: Покупатель, продавец, администратор (скрытая)
    /// </summary>
    public UserTypes Profession { get; set; }
}