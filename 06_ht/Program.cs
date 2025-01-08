using _06_ht;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product = new Product("Chocolate", 10, 50);
        product.Print();
        product.ReducePrice(1, 75);
        product.PrintProduct();

        Device kettle = new Kettle("Kettle", "Metal, 2l");
        kettle.Show();
        kettle.Sound();
        kettle.Desc();

        Musical_Instrument violin = new Violin("Violin", "Wood, clasical");
        violin.Show();
        violin.Sound();
        violin.Desc();
        violin.History();

        Worker manager = new Manager();
        manager.Print();
    }
}