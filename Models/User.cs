namespace LibraryApp.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public BookCopy BookCopy { get; set; }

        public int BookCopyId { get; set; }

        public UserRole role { get; set; } = UserRole.User;

    }
}
