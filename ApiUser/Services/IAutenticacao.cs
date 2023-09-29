

namespace ApiUser.Services
{
    public interface IAutenticacao
    {
        Task<bool> AutenticacaoAsync(string carteira, string senha);
    }
}