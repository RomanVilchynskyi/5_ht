using _04_ht;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Web_site site = new Web_site(
                 "My Site",
                 "http://mysite.com",
                 "This is a test",
                 "192.168.0.1"
             );

         site.print();

         site.SetName("new Site");
         site.SetDescription("This is an updated description.");

         Console.WriteLine("\nAfter update:");
         site.print();*/

        Magazine mag = new Magazine("New magazine", 2014, "new description", 1234567890, "example@gmail.com");
        mag.print();
        mag.SetYear(2023);
        mag.SetEmail("aasfaff@gmail.com");
        Console.WriteLine("\nAfter update:");
        mag.print();
    }
}