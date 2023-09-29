using projeto.ApiUser.Context;
using projeto.ApiUser.Models;

namespace ApiUser.Services
{
    public class AutenticacaoService : IAutenticacao
    {
        private readonly AppDbContext _dbContext;

        public AutenticacaoService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public AutenticacaoService()
        {
            
        }

        async Task<bool> IAutenticacao.AutenticacaoAsync(string carteira, string senha)
        {
            var usuario =  _dbContext.Users.
                Where(x => x.Carteira == carteira && x.Senha == senha).FirstOrDefault();
            if (usuario == null) 
            {
                return false;
            }

            return true;
        }

    }
}
