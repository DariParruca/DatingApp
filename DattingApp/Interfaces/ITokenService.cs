using DattingApp.Entities;

namespace DatingApp.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
