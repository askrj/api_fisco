using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.Api_fisco.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }

        [Required]
        [StringLength(9)]
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
    }
}