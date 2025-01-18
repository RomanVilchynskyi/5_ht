using _11_ht;

internal class Program
{
    public static void PrintBooks(List<Book> books)
    {
        if (books.Count == 0)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
        }
    }
    private static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
           new Book("The Master and Margarita", "Mikhail Bulgakov", "Novel", 1967),
            new Book("Shadows of Forgotten Ancestors", "Mykhailo Kotsiubynsky", "Story", 1911),
            new Book("1984", "George Orwell", "Dystopia", 1949),
            new Book("Kobzar", "Taras Shevchenko", "Poetry", 1840)
        };

        Console.WriteLine("List of books:");
        PrintBooks(books);

        books.Add(new Book("Faust", "Johann Wolfgang von Goethe", "Tragedy", 1808));
        Console.WriteLine("\nAfter adding a book:");
        PrintBooks(books);

        books.RemoveAt(1); 
        Console.WriteLine("\nAfter removing a book:");
        PrintBooks(books);

        books[2] = new Book("Animal Farm", "George Orwell", "Dystopia", 1945);
        Console.WriteLine("\nAfter updating the third book:");
        PrintBooks(books);

        books.Insert(0, new Book("Crime and Punishment", "Fyodor Dostoevsky", "Novel", 1866));
        Console.WriteLine("\nAfter inserting a book at the beginning:");
        PrintBooks(books);

        books.Add(new Book("Ivanhoe", "Walter Scott", "Novel", 1819));
        Console.WriteLine("\nAfter inserting a book at the end:");
        PrintBooks(books);

        books.RemoveAt(0);
        Console.WriteLine("\nAfter removing a book from the beginning:");
        PrintBooks(books);

        books.RemoveAt(books.Count - 1);
        Console.WriteLine("\nAfter removing a book from the end:");
        PrintBooks(books);
    }
}