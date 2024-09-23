using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst
{
  public class Product
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId { get; set; }
    [Required]
    [Column(TypeName = "varchar(100)")]
    public string Name { get; set; }
    public string Price { get; set; }
    [ForeignKey("Category")]
    public int CategoryId { get; set; }


    //[Foreignkey("CategoryId")]
    // Navigation property
    public Category Category { get; set; }
  }
}
