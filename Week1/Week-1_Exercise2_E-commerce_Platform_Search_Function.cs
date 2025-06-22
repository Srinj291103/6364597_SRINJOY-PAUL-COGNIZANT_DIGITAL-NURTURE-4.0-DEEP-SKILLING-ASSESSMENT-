using System;

class Product
{
    public int Id;
    public string Name;
    public string Category;

    public Product(int id, string name, string category)
    {
        Id = id;
        Name = name;
        Category = category;
    }

    public void Show()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Category: {Category}");
    }
}

class ProductSearch
{
    public static Product LinearSearch(Product[] products, string target)
    {
        foreach (var product in products)
        {
            if (product.Name.Equals(target, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null;
    }

    public static Product BinarySearch(Product[] products, string target)
    {
        
        Array.Sort(products, (a, b) => a.Name.CompareTo(b.Name));

        int low = 0, high = products.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int cmp = string.Compare(products[mid].Name, target, StringComparison.OrdinalIgnoreCase);

            if (cmp == 0)
                return products[mid];
            else if (cmp < 0)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return null;
    }

    static void Main(string[] args)
    {
        Product[] productList = {
            new Product(1, "Tablet", "Electronics"),
            new Product(2, "Boots", "Apparel"),
            new Product(3, "Cupboard", "Furniture"),
            new Product(4, "Laptop", "Electronics")
        };

        string targetName = "Mobile";

        Console.WriteLine(" Linear Search:");
        var result1 = LinearSearch(productList, targetName);
        if (result1 != null)
            result1.Show();
        else
            Console.WriteLine("Product not found.");

        Console.WriteLine("\n Binary Search:");
        var result2 = BinarySearch(productList, targetName);
        if (result2 != null)
            result2.Show();
        else
            Console.WriteLine("Product not found.");
    }
}
