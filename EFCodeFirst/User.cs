using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
  internal class User
  {
    public int UserId { get; set; }

    [Required]
    [Column(TypeName = "varchar(59)")]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "varchar(59)")]
    public string Email { get; set; }
    public string Password { get; set; }

  }
}
