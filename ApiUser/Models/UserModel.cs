using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCatalogo.Models;

public class UserModel
{


    [StringLength(9)]
    public string? UserName { get; set; }

    [StringLength(15)]
    public string? Password { get; set; }
}
