using examentity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examentity
{
    public class LibraryDbContex:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
                                      
            optionsBuilder.UseSqlServer(@"workstation id=shoppingslay.mssql.somee.com;packet size=4096;
user id=kseniahaliyy_SQLLogin_1;pwd=qetx4lr9px;data source=shoppingslay.mssql.somee.com;
persist security info=False;initial catalog=shoppingslay;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Fluent API
            //  [Required, MaxLength(100)]//not null, nvarchar(100)   
            modelBuilder.Entity<Author>()
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Author>()
               .Property(a => a.Surname)
               .HasMaxLength(100)
               .IsRequired();
            modelBuilder.Entity<Country>()
               .Property(a => a.Name)
               .HasMaxLength(100)
               .IsRequired();
            modelBuilder.Entity<Genre>()
               .Property(a => a.Name)
               .HasMaxLength(100)
               .IsRequired();

            modelBuilder.Entity<Publisher>()
               .Property(a => a.Name)
               .HasMaxLength(100)
               .IsRequired();
            modelBuilder.Entity<Book>()
               .Property(a => a.Name)
               .HasMaxLength(100)
               .IsRequired();
            modelBuilder.Entity<Book>()
               .Property(a => a.Description)
               .HasMaxLength(100)
               .IsRequired();








            //Relationship Configuration
            modelBuilder.Entity<Publisher>().HasMany(p => p.Books).WithOne(b => b.Publisher).HasForeignKey(b => b.PublisherId);
            modelBuilder.Entity<Genre>().HasMany(g => g.Books).WithOne(b => b.Genre).HasForeignKey(b => b.GenreId);
            modelBuilder.Entity<Author>().HasMany(a => a.Books).WithOne(b => b.Author).HasForeignKey(b => b.AuthorId);
            modelBuilder.Entity<Country>().HasMany(c => c.Authors).WithOne(a => a.Country).HasForeignKey(b => b.PublisherId);


            //Initialization - Seeder
            modelBuilder.SeedAirplanes();
            modelBuilder.SeedFlight();

        }
    }
}
