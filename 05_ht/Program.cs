using _05_ht;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var card = new CreditCard("Denis", "1234567812345670", "12/25", "123");
            Console.WriteLine(card);
            Console.WriteLine("Card is valid");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Validation failed: {ex.Message}");
        }
    }
}