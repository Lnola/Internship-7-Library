using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Library.Data.Entities
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookBorrow> BookBorrows { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LibraryContext"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookBorrow>()
                .HasOne(bb => bb.Book)
                .WithMany(b => b.BookBorrows)
                .HasForeignKey(bb => bb.BookId);
            modelBuilder.Entity<BookBorrow>()
                .HasOne(bb => bb.Student)
                .WithMany(b => b.BookBorrows)
                .HasForeignKey(bb => bb.StudentId);
        }
    }
}
