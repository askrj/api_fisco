

using projeto.ApiUser.Models;

namespace ApiUser.Services;

public interface ITokenService
{
    string GerarToken(string key, string issuer,string audience, UserModel user);
}
