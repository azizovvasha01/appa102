using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesCollections.GenericTypesCollections
{
    internal class BookManager
    {
        public List<Book> Books { get; }
        public Dictionary<string, List<Book>> BooksByAuthor { get; }
        public Queue<string> WaitingQueue { get; }
        public Stack<Book> RecentlyReturned { get; }

        public BookManager()
        {
            Books = new List<Book>();
            BooksByAuthor = new Dictionary<string, List<Book>>();
            WaitingQueue = new Queue<string>();
            RecentlyReturned = new Stack<Book>();
        }

        public void AddBook(Book book)
        {
            if (book == null) return;

            Books.Add(book);

            if (!BooksByAuthor.ContainsKey(book.Author))
                BooksByAuthor[book.Author] = new List<Book>();

            BooksByAuthor[book.Author].Add(book);
        }

        public Book SearchByTitle(string title)
        {
            foreach (var b in Books)
            {
                if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    return b;
            }
            return null;
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            if (BooksByAuthor.ContainsKey(author))
                return BooksByAuthor[author];
            return new List<Book>();
        }

        public void AddToWaitingQueue(string memberName)
        {
            WaitingQueue.Enqueue(memberName);
            Console.WriteLine($"{memberName} növbeye elave olundu");
        }

        public string ServeNextInQueue()
        {
            if (WaitingQueue.Count == 0) return null;
            return WaitingQueue.Dequeue();
        }

        public void ReturnBook(Book book)
        {
            RecentlyReturned.Push(book);
            Console.WriteLine($"Kitab qebul edildi: {book.Title}");
        }

        public Book GetLastReturnedBook()
        {
            if (RecentlyReturned.Count == 0) return null;
            return RecentlyReturned.Peek();
        }
    }
}
