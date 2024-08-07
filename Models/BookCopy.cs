namespace LibraryApp.Models
{
    public class BookCopy
    {

        public int Id { get; set; }

        public Book Book { get; set; }

        public Boolean isAvailable { get; set; }

        public int BookId { get; set; }

    
      

        public ICollection<User_BookCopy> User_BookCopies { get; set; } = new List<User_BookCopy>();

       
    }
}
