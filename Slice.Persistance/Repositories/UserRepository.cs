using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Models;
using Domain.Repositories.IRepository;
using Microsoft.IdentityModel.Tokens;
using Note.Domain;
using Slice.Persistance;

namespace Domain.Repositories;

public class UserRepository: IUserRepository
{
    private readonly AppDBContext _db;
    private string secretKey;

    public UserRepository(AppDBContext db)
    {
        _db = db;
        secretKey = "this is my custom Secret key for authentication";
    }

    public bool IsUniqueUser(string username)
    {
        return true;
    }

    public async Task<UserResponceDto> Login(ShortUserDto shortUserDto)
    {
        var user = _db.User.FirstOrDefault(user => user.Login.ToLower() == shortUserDto.Login.ToLower()
                                                   && user.Password.ToLower() == shortUserDto.Password.ToLower());
        if (user == null)
        {
            return new UserResponceDto()
            {
                Token = "",
                User = null
            };
        }

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(secretKey);
        var tokenDescriptor = new SecurityTokenDescriptor()
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, user.id.ToString())
            }),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
                
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        UserResponceDto responceDto = new UserResponceDto()
        {
            Token = tokenHandler.WriteToken(token),
            User = user
        };
        return responceDto;
    }
    
    public async Task<User> Register(User user)
    {
        User loginUser = new()
        {
            Email = user.Email,
            Login = user.Login,
            Password = user.Password,
            Age = user.Age,
            Sex = user.Sex
                
        };
        _db.User.Add(loginUser);
        await _db.SaveChangesAsync();
        user.Password = "";
        return loginUser;
    }
}