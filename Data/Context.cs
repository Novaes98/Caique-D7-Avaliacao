using Microsoft.EntityFrameworkCore;
using System;

namespace Caique_D7_avaliacao.Data
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Register> Registers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Register>().HasData(GetRegisters());
            base.OnModelCreating(modelBuilder);
        }

        private static Register[] GetRegisters()
        {
            return new Register[]
            {
            new Register
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                Email = "admin@email.com",
                Password = "admin123"
            }};
        }
    }
}
