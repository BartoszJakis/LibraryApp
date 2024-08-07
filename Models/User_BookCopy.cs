namespace LibraryApp.Models
{
    public class User_BookCopy
    {

        public int Id { get; set; }
        public int BookCopyId {  get; set; }
       public BookCopy BookCopy { get; set; }
        public int UserId {  get; set; }

        public User User { get; set; }

        public DateTime BorrowedDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
    }
}
