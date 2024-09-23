using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst
{
  public class Category
  {
    public int CategoryId { get; set; }

    [Column(TypeName = "varchar(59)")]
    public string Name { get; set; }
  }
}
