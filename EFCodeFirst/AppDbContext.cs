using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
  internal class AppDbContext: DbContext
  {
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<User> User { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      
      if(!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=EFDb22Db;Integrated Security=True;TrustServerCertificate=True;");

      } 
    }
  }
}
