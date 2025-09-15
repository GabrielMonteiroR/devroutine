using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devroutine.Models;

[Table("users")]
public class User
{
    [Key]
    [Column("name")]
    public string Name { get; set; }

    [Column("email")]
    [EmailAddress]
    public string Email { get; set; }

    [Column("password")]
    public string password { get; set; }
}