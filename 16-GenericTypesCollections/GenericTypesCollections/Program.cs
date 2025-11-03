
using GenericTypesCollections.GenericTypesCollections;

internal class Program
{
    static void Main(string[] args)
    {
        
        Book book1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
        Book book2 = new Book(2, "1984", "George Orwell", 1949, 328);
        Book book3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
        Book book4 = new Book(4, "Ağ Gəmi", "Cingiz Aytmatov", 1970, 200);
        Book book5 = new Book(5, "Qırıq Budaq", "Elçin", 1998, 350);



        book1.DisplayInfo();
        book2.DisplayInfo();
        book3.DisplayInfo();
        book4.DisplayInfo();
        book5.DisplayInfo();

        Librariy<Book> lib = new Librariy<Book>("Milli Kitabxana");
        lib.Add(book1);
        lib.Add(book2);
        lib.Add(book3);
        lib.Add(book4);
        lib.Add(book5);

        Console.WriteLine($"Kitab sayı: {lib.Count()}");

        
        Memmber m = new Memmber(1, "Ali Məmmədov", "ali@mail.com");
        m.BorrowBook(book1);
        m.BorrowBook(book2);
        m.DisplayBorrowedBooks();
        m.ReturnBook(1);
        m.DisplayBorrowedBooks();

        
        BookManager manager = new BookManager();
        manager.AddBook(book1);
        manager.AddBook(book2);
        manager.AddBook(book3);
        manager.AddBook(book4);
        manager.AddBook(book5);

        Console.WriteLine("\nGeorge Orwell-in kitabları:");
        foreach (var bk in manager.GetBooksByAuthor("George Orwell"))
            bk.DisplayInfo();

        
        manager.AddToWaitingQueue("Nigar");
        manager.AddToWaitingQueue("Rəşad");
        Console.WriteLine($"Xidmət edilir: {manager.ServeNextInQueue()}");

        manager.ReturnBook(book1);
        manager.ReturnBook(book2);
        manager.ReturnBook(book3);
        manager.ReturnBook(book4);
        manager.ReturnBook(book5);
        Console.WriteLine("Son qaytarılan kitab:");
        manager.GetLastReturnedBook()?.DisplayInfo();
    }
}