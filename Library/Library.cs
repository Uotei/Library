using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        public List<BorrowedBook> BorrowedBooks { get; set; } = new List<BorrowedBook>();
        public static List<Book> Books { get; set; } = new List<Book>();
        public static List<User> Users { get; set; } = new List<User>();
        public static void AddBook(int id, string title, string author, string releaseDate, string publisher, string isbn, string genre, int stock)
        {
            var book = new Book
            {
                ID = id,
                Title = title,
                Author = author,
                ReleaseDate = int.Parse(releaseDate),
                Publisher = publisher,
                ISBN = isbn,
                Genre = genre,
                Stock = stock
            };

            Books.Add(book);
            Console.WriteLine("Dodałeś książkę: " + title);
        }

        public void DeleteBook(int id)
        {
            var book = Books.Find(x => x.ID == id);
            if (book != null)
            {
                Books.Remove(book);
            }
        }

        public void EditBook(int? id, string title, string author, string releaseDate, string publisher, string isbn, string genre, int stock)
        {
            var book = Books.Find(x => x.ID == id);

            /*{
                ID = id,
                Title = title,
                Author = author,
                ReleaseDate = DateTime.Parse(releaseDate),
                Publisher = publisher,
                ISBN = isbn,
                Genre = genre
                Stock = stock
            };*/
        }
    }
}
