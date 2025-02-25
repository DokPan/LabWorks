Product product1 = new Product("Электроника", "Смартфон", 1000);
Console.WriteLine("Исходный объект:");
product1.PrintFullInfo();

Product incrementedProduct = ++product1;
Console.WriteLine("\nОбъект после применения ++:");
incrementedProduct.PrintFullInfo();


Product product2 = new Product("Электроника", "Наушники", 800);
Console.WriteLine("\nОбъекты для сложения:");
product1.PrintFullInfo();
product2.PrintFullInfo();

Product combinedProduct = product1 + product2;
Console.WriteLine("\nРезультат сложения объектов:");
combinedProduct.PrintFullInfo();

Product product3 = new Product("Электроника", "Смартфон", 1001);
Console.WriteLine("\nСравнение объектов:");
Console.WriteLine($"product1 == product3: {product1 == product3}");
Console.WriteLine($"product1 != product2: {product1 != product2}");

Product product4 = new Product("Одежда", "Куртка", -500);
Console.WriteLine("\nТест унарных операторов true и false:");
Console.WriteLine("product4 (цена отрицательная):");
product4.PrintFullInfo();

if (product4)
    Console.WriteLine("product4: Цена положительная или равна нулю.");
else
    Console.WriteLine("product4: Цена отрицательная.");
