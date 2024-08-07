using Microsoft.EntityFrameworkCore;
using LibraryApp.Models;

namespace LibraryApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Book> Books { get; set; }
        public DbSet<BookCopy> BookCopies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_BookCopy> User_BookCopies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>()
                .HasMany(b => b.BookCopies)
                .WithOne(bc => bc.Book)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCopy>()
                .HasMany(bc => bc.User_BookCopies)
                .WithOne(ubc => ubc.BookCopy)
                .HasForeignKey(ubc => ubc.BookCopyId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.User_BookCopies)
                .WithOne(ubc => ubc.User)
                .HasForeignKey(ubc => ubc.UserId);

            modelBuilder.Entity<User_BookCopy>()
                .HasOne(ubc => ubc.BookCopy)
                .WithMany(bc => bc.User_BookCopies)
                .HasForeignKey(ubc => ubc.BookCopyId);

            modelBuilder.Entity<User_BookCopy>()
                .HasOne(ubc => ubc.User)
                .WithMany(u => u.User_BookCopies)
                .HasForeignKey(ubc => ubc.UserId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
