using bookavid_backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookavid_backend.Contexts
{
    public class BookavidContext : IdentityDbContext
    {
        public BookavidContext(DbContextOptions<BookavidContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(new Category { Id = 1, Name = "Klassik" });
            builder.Entity<Category>().HasData(new Category { Id = 2, Name = "Psixologiya" });
            builder.Entity<Category>().HasData(new Category { Id = 3, Name = "Dedektiv" });
            builder.Entity<Category>().HasData(new Category { Id = 4, Name = "Tarix" });
            builder.Entity<Category>().HasData(new Category { Id = 5, Name = "Hüquq" });
            builder.Entity<Category>().HasData(new Category { Id = 6, Name = "Bioqrafiya" });
            builder.Entity<Category>().HasData(new Category { Id = 7, Name = "Dərsliklər/Testlər" });
            builder.Entity<Category>().HasData(new Category { Id = 8, Name = "Şəxsi inkişaf" });
            builder.Entity<Category>().HasData(new Category { Id = 9, Name = "Bədii Ədəbiyyat" });
            builder.Entity<Category>().HasData(new Category { Id = 10, Name = "Uşaq ədəbiyyatı" });
            builder.Entity<Category>().HasData(new Category { Id = 11, Name = "Romantik" });
            builder.Entity<Category>().HasData(new Category { Id = 12, Name = "Digər" });


            // Digər lazım olan Db məlumatların burdan add edə bilərsiniz
        }

        //Db-ə modellerin add olunması

        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Status> Statuses { get; set; }

    }
}
