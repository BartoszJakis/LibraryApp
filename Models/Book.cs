﻿namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public string Description { get; set; }

        public ICollection<BookCopy> BookCopies { get; set; } = new List<BookCopy>();

    }
}
