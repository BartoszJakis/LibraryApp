namespace LibraryApp.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        
        public ICollection<User_BookCopy>User_BookCopies { get; set; } = new List<User_BookCopy>();
        

        public UserRole role { get; set; } = UserRole.User;

    }
}
