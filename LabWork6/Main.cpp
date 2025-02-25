Product defaultProduct = new Product();
Console.WriteLine("Объект, созданный конструктором по умолчанию:");
defaultProduct.PrintFullInfo();
Console.WriteLine();
Product parametrProduct = new Product("Электроника", "Чайник", 3500);
Console.WriteLine("Объект, созданный конструктором:");
parametrProduct.PrintFullInfo();
Console.WriteLine();

Console.WriteLine("Демонстрация работы строкового индексатора:");
Console.WriteLine($"Тип: {parametrProduct["type"]}");
Console.WriteLine($"Наименование: {parametrProduct["name"]}");
Console.WriteLine($"Цена: {parametrProduct["price"]}");
Console.WriteLine($"Некорректный индекс: {parametrProduct["invalid"]}");
Console.WriteLine("\nДемонстрация работы индексатора по символам:");
Console.WriteLine($"Первый символ поля type: {parametrProduct[0]}");
Console.WriteLine($"Некорректный индекс: {parametrProduct[100]}");
Console.WriteLine();

Calculations calculations = new Calculations();
Console.WriteLine("Площадь квадрата со стороной 5:");
Console.WriteLine(calculations.GetSquare(5));
Console.WriteLine("\nПлощадь прямоугольника со сторонами 5 и 10:");
Console.WriteLine(calculations.GetSquare(5, 10));

Console.WriteLine("\nРациональная функция 1/x^n для x=2, n=3:");
Console.WriteLine(calculations.GetRationalFunction(2, 3));
Console.WriteLine("\nРациональная функция 1/x для x=4:");
Console.WriteLine(calculations.GetRationalFunction(4));
Console.WriteLine("\nНекорректные данные для функций:");
Console.WriteLine(calculations.GetRationalFunction(0, 3)); 
Console.WriteLine(calculations.GetRationalFunction(0));
