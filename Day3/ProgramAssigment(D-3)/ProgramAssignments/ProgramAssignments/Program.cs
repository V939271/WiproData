using System;

struct Product
{
    public string Name;
    public decimal Price;
    public int Quantity;

    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}

class Program
{
    static void Main(string[] args)
    {
        const int maxProducts = 100;
        Product[] products = new Product[maxProducts];
        int productCount = 0;

        while (true)
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if (productCount < maxProducts)
                    {
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter product price: ");
                        decimal price = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Enter product quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        products[productCount] = new Product(name, price, quantity);
                        productCount++;
                        Console.WriteLine("Product added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Inventory is full!");
                    }
                    break;

                case "2":
                    for (int i = 0; i < productCount; i++)
                    {
                        // Updated price formatting: removes unnecessary trailing zero
                        Console.WriteLine($"Name: {products[i].Name}, Price: {products[i].Price.ToString("0.#")}, Quantity: {products[i].Quantity}");
                    }
                    break;

                case "3":
                    Console.Write("Enter product name to update: ");
                    string updateName = Console.ReadLine();
                    bool found = false;

                    for (int i = 0; i < productCount; i++)
                    {
                        if (products[i].Name.Equals(updateName, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Write("Enter new price: ");
                            products[i].Price = Convert.ToDecimal(Console.ReadLine());

                            Console.Write("Enter new quantity: ");
                            products[i].Quantity = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Product updated successfully!");
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Product not found!");
                    }
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}