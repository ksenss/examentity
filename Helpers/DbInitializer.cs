using examentity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace examentity.Helpers
{

    public static class DbInitializer
    {
        public static void SeedGenre(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                 new Genre[]
                 {
                    new Genre()
                    {
                        Id = 1,
                        Name = "Romance",

                    },
                    new Genre()
                    {
                        Id = 2,
                        Name = "Thriller",

                    }
                 });
        }
        public static void SeedCountry(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                 new Country[]
                 {
                    new Country()
                    {
                        Id = 1,
                        Name = "Ukraine",

                    },
                    new Country()
                    {
                        Id = 2,
                        Name = "Poland",

                    },
                      new Country()
                    {
                        Id = 3,
                        Name = "Spain",

                    }
                 });
        }
        public static void SeedAuthor(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData((
                  new Author[]
                  {
                    new Author()
                    {
                         Id= 1,
                        Name="Agata",
                         Surname="Khristie",
                         Birthdate = new DateTime(2018,09,24),
                        Countryid  =1

                    },
                     new Author()
                    {
                         Id=2,
                        Name="Tatas",
                         Surname="Shevchenko",
                         Birthdate = new DateTime(1950,07,21),
                          Countryid  =3
                    },
                      new Author()
                    {
                         Id=3,
                        Name="Federico",
                         Surname="García Lorca",
                         Birthdate = new DateTime(2009,04,15),
                          Countryid  =2
                    }
                  }));
        }
        public static void SeedPublisher(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publisher>().HasData(
                 new Publisher[]
                 {
                    new Publisher()
                    {
                        Id = 1,
                        Name = "Ranok",

                    },
                    new Publisher()
                    {
                        Id = 2,
                        Name = "Rainbow",

                    }
                 });
        }
        public static void SeedBook(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book[]
                {
            new Book()
            {
                Id = 1,
                Name = "Harry Potter and the Philosopher's Stone",
                Description = "The first book in the Harry Potter series.",
                MaxPages = 320,
                Year = 1997,
                AuthorId = 1,
                PublisherId = 1,
                GenreId = 1
            },
            new Book()
            {
                Id = 2,
                Name = "War and Peace",
                Description = "An epic novel by Leo Tolstoy about the Napoleonic wars.",
                MaxPages = 1225,
                Year = 1869,
                AuthorId = 2,
                PublisherId = 2,
                GenreId = 2
            }
                });
        }
    }
    }



