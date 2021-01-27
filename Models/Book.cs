using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xBindDataExample.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string CoverImage { get; set; }

    }
    public class BookManager
    {
        public static List<Book> GetBooks() {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Futurum", CoverImage = "Assets/2.png" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Futurum", CoverImage = "Assets/3.png" });
            books.Add(new Book { BookId = 4, Title = "Etiam", Author = "Futurum", CoverImage = "Assets/4.png" });
            books.Add(new Book { BookId = 5, Title = "Erat", Author = "Futurum", CoverImage = "Assets/5.png" });
            books.Add(new Book { BookId = 6, Title = "Nostrud", Author = "Futurum", CoverImage = "Assets/6.png" });
            books.Add(new Book { BookId = 7, Title = "PerModo", Author = "Futurum", CoverImage = "Assets/7.png" });
            books.Add(new Book { BookId = 8, Title = "subcrip", Author = "Futurum", CoverImage = "Assets/8.png" });
            books.Add(new Book { BookId = 9, Title = "Decima", Author = "Futurum", CoverImage = "Assets/9.png" });
            books.Add(new Book { BookId = 10, Title = "Erat", Author = "Futurum", CoverImage = "Assets/10.png" });
            books.Add(new Book { BookId = 11, Title = "Consequat", Author = "Futurum", CoverImage = "Assets/11.png" });
            books.Add(new Book { BookId = 12, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/12.png" });
            books.Add(new Book { BookId = 13, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/13.png" });

            return books;





        }
    }
}
