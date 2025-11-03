using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesCollections.GenericTypesCollections
{
    internal class Memmber
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }
        public List<Book> BorrowedBooks { get; }

        public Memmber(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count >= 3)
            {
                Console.WriteLine("Max 3 kitab götüre bilersiniz!");
                return;
            }

            BorrowedBooks.Add(book);
            Console.WriteLine($"Kitab götürüldü: {book.Title}");
        }

        public void ReturnBook(int bookId)
        {
            Book found = null;

            foreach (var b in BorrowedBooks)
            {
                if (b.Id == bookId)
                {
                    found = b;
                    break;
                }
            }

            if (found != null)
            {
                BorrowedBooks.Remove(found);
                Console.WriteLine($"Kitab qaytarıldı: {found.Title}");
            }
            else
            {
                Console.WriteLine($"Bele ID-li borc kitab tapılmadı: {bookId}");
            }
        }

        public void DisplayBorrowedBooks()
        {
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("Borc kitab yoxdur");
                return;
            }

            foreach (var b in BorrowedBooks)
            {
                b.DisplayInfo();
            }
        }
    }
}
