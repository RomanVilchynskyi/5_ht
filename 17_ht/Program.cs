class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public DateTime ManufactureDate { get; set; }
    public string Country { get; set; }
    public string Category { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1500, ManufactureDate = new DateTime(2025, 1, 10), Country = "USA", Category = "Electronics" },
            new Product { Name = "Phone", Price = 800, ManufactureDate = new DateTime(2024, 5, 20), Country = "China", Category = "Electronics" },
            new Product { Name = "Table", Price = 200, ManufactureDate = new DateTime(2025, 3, 15), Country = "Ukraine", Category = "Furniture" },
            new Product { Name = "Sofa", Price = 500, ManufactureDate = new DateTime(2023, 7, 10), Country = "Poland", Category = "Furniture" },
            new Product { Name = "TV", Price = 1200, ManufactureDate = new DateTime(2025, 2, 25), Country = "Japan", Category = "Electronics" }
        };

        int curYear = DateTime.Now.Year;
        string selCountry = "China";
        string selCategory = "Electronics";

        var recentProducts = products.Where(p => p.ManufactureDate.Year == curYear).OrderByDescending(p => p.Price);

        int countByCountry = products.Count(p => p.Country == selCountry);

        var categoryProducts = products.Where(p => p.Category == selCategory);
        var mostExpensive = categoryProducts.OrderByDescending(p => p.Price).FirstOrDefault();
        var cheapest = categoryProducts.OrderBy(p => p.Price).FirstOrDefault();

        var categoriesWithoutUkraine = products.GroupBy(p => p.Category).Where(g => !g.Any(p => p.Country == "Ukraine")).Select(g => g.Key);

        var productCounts = products.GroupBy(p => p.Category).Select(g => new { Category = g.Key, Count = g.Count() });

        var groupedProducts = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key,Products = g.OrderBy(p => p.ManufactureDate)});

        Console.WriteLine("Products of this year:");
        foreach (var p in recentProducts)
            Console.WriteLine($"{p.Name} - {p.Price} USD");

        Console.WriteLine($"\nNumber of products from {selCountry}: {countByCountry}");

        Console.WriteLine("\nMost expensive and cheapest product in category " + selCategory + ":");
        Console.WriteLine(mostExpensive != null ? $"Expensive: {mostExpensive.Name} - {mostExpensive.Price} USD" : "No products");
        Console.WriteLine(cheapest != null ? $"Cheap: {cheapest.Name} - {cheapest.Price} USD" : "No products");

        Console.WriteLine("\nCategories whose products are not manufactured in Ukraine:");
        foreach (var category in categoriesWithoutUkraine)
            Console.WriteLine(category);

        Console.WriteLine("\nNumber of products in each category:");
        foreach (var item in productCounts)
            Console.WriteLine($"{item.Category}: {item.Count} products");

        Console.WriteLine("\nGrouped products by categories:");
        foreach (var group in groupedProducts)
        {
            Console.WriteLine($"Category: {group.Category}");
            foreach (var product in group.Products)
                Console.WriteLine($"  {product.Name} - {product.ManufactureDate:yyyy-MM-dd}");
        }
    }
}
