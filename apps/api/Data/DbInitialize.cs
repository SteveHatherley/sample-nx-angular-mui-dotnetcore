using Microsoft.EntityFrameworkCore;
using Init.Api.Models;

namespace Init.Api.Data
{

  public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;
        public DbInitializer(ModelBuilder builder) 
        {
            _modelBuilder = builder;
        }
        public void Seed()
        {
            _modelBuilder.Entity<InventoryItem>(inv =>{
                inv.HasData(new InventoryItem{
                    Id = Guid.NewGuid(),
                    Description = "Self-Sealing Stem Bolts",
                    Quantity = 100
                });
                inv.HasData(new InventoryItem{
                    Id = Guid.NewGuid(),
                    Description = "Yamok Sauce",
                    Quantity = 5000
                });
            });
        }
        
    }

}