using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage2.Models.Entities;

namespace Storage2.Data
{
    public class Storage2Context : DbContext
    {
        public Storage2Context (DbContextOptions<Storage2Context> options)
            : base(options)
        {
        }

        public DbSet<Storage2.Models.Entities.Product> Product { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product {Id =1, Name="Dirt", Price=1, OrderDate=DateTime.Parse("2025-01-08"), Category = Category.Block, Count=320, Description= "A dirt block. Can be tilled to grow seeds. Will grow grass or mycelium if placed next to source block" },
                new Product { Id = 2, Name = "Stone", Price = 5, OrderDate = DateTime.Parse("2025-04-03"), Category = Category.Block, Count = 320, Description = "Smooth stone. Can be crafted into stone bricks or redstone components. Great for natural landscape builds" },
                new Product { Id = 3, Name = "Wood", Price = 12, OrderDate = DateTime.Parse("2025-01-08"), Category = Category.Block, Count = 640, Description = "Oak wood. Can be crafted into Oak Wood Planks or shaved to make Shaved Oak Wood" },
                new Product { Id = 4, Name = "Glowstone", Price = 80, OrderDate = DateTime.Parse("2025-06-24"), Category = Category.Block, Count = 200, Description = "From the nether. Emits a yellow light. Can be crafted into redstone lamp." },
                new Product { Id = 5, Name = "Stone sword", Price = 60, OrderDate = DateTime.Parse("2025-01-08"), Category = Category.Weapon, Count = 5, Description = "Basic sword. Gread for beginners!" },
                new Product { Id = 6, Name = "Infinity Bow", Price = 1200, OrderDate = DateTime.Parse("2025-01-08"), Category = Category.Weapon, Count = 1, Description = "Bow with the Infinity Enchantment. Never run out of ammo again!" },
                new Product { Id = 7, Name = "Diamond pickaxe", Price = 2000, OrderDate = DateTime.Parse("2025-01-08"), Category = Category.Tool, Count = 5, Description = "The second best pickaxe. Great speed and durability! Can be crafted into a netherite pickaxe" }

                );
        }
    }
}
