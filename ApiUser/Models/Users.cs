
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace projeto.ApiUser.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }

        public string? Carteira { get; set; }

        [Required]
        [StringLength(15)]
        public string? Senha { get; set; }

        [Required]
        [StringLength(11)]
        public string? CPF { get; set; }

        [Required]
        [StringLength(80)]
        public string? Email { get; set; }

        ICollection<Users>? _users { get; set; }

    }
}