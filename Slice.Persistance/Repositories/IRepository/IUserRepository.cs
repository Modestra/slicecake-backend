using Domain.Models;
using Note.Domain;

namespace Domain.Repositories.IRepository;

public interface IUserRepository
{
    public bool IsUniqueUser(string username);
    Task<UserResponceDto> Login(ShortUserDto shortUserDto);
    Task<User> Register(User user);
}