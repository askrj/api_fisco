


using System.ComponentModel.DataAnnotations;

namespace projeto.ApiUser.Models
{
    public class UserModel
    {

        [StringLength(9)]
        public string? Carteira { get; set; }

        [StringLength(15)]
        public string? Senha { get; set; }
    }
}