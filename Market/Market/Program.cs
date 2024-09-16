using Market;

public class Program
{
    public static void Main()
    {
        Product[] products = new Product[]
        {
            new Toy("Plastic", 10.99m),
            new Meat(DateTime.Now.AddDays(5), 15.49m),
            new Drink(500, 2.99m),
            new Snack(200, 1.99m),
            new Electronics(24, 299.99m)
        };

        decimal discountPercentage = 10;  // Размер скидки

        foreach (var product in products)
        {
            Console.WriteLine(product.GetInformation());
            Console.WriteLine($"Discounted Price: {product.GetDiscountedPrice(discountPercentage):C}\n");
        }
    }
}
