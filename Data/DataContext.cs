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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCopy>()
                .HasOne(bc => bc.User)
                .WithOne(u => u.BookCopy)
                .HasForeignKey<BookCopy>(bc => bc.UserId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.BookCopy)
                .WithOne(bc => bc.User)
                .HasForeignKey<User>(u => u.BookCopyId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
