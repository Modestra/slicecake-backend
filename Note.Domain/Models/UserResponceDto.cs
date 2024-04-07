using Note.Domain;

namespace Domain.Models;

public class UserResponceDto
{
    public User User { get; set; }
    public string Token { get; set; }
}