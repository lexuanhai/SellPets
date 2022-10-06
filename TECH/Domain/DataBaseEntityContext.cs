using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DataBaseEntityContext : DbContext
    {
        public DataBaseEntityContext(DbContextOptions<DataBaseEntityContext> options) : base(options) { }

        public DbSet<Users> Users { set; get; }
        public DbSet<Contracts> Contracts { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Products> Products { set; get; }
        public DbSet<Orders> Orders { set; get; }
        public DbSet<Reviews> Reviews { set; get; }
        public DbSet<Fees> Fees { set; get; }
        public DbSet<City> Cities { set; get; }
        public DbSet<OrdersDetails> OrdersDetails { set; get; }
        public DbSet<Districts> Districts { set; get; }
        public DbSet<Wards> Wards { set; get; }
        //public DbSet<Siders> siders { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);            
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>()
        //        .HasMany<Products>(g => g.Products)
        //        .WithOne(s => s.Category)
        //        .HasForeignKey(s=>s.category_id)
        //        .OnDelete(DeleteBehavior.Cascade);
        //}
    }
}
