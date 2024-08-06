namespace LibraryApp.Models
{
    public class BookCopy
    {

        public int Id { get; set; }

        public Book Book { get; set; }

        public Boolean isAvailable { get; set; }

        public int BookId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
