Product product2 = new("Химия", "Порошок", 80);
Product product3 = new("Химия", "Антисептик", 150);
Console.WriteLine();
Console.WriteLine($"product1 == product2: {product1.Equals(product2)}");
Console.WriteLine($"product1 == product3: {product1.Equals(product3)}");
Console.WriteLine();

Product original = new("Химия", "Гель", 180);
Product clone = (Product)original.Clone();
original.PrintFullInfo();
clone.PrintFullInfo();
Console.WriteLine();

Array.Sort(products, new DescendingComparer());
foreach (var product in products)
    product.PrintFullInfo();
Console.WriteLine();
Array.Sort(products, new StringComparer());
foreach (var product in products)
    product.PrintFullInfo();
