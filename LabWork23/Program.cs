using LabWorkLibrary;
Console.WriteLine("Использование математической библиотеки:");
Console.WriteLine($"5 + 3 = {Maths.Add(5, 3)}");
Console.WriteLine($"5 - 3 = {Maths.Subtract(5, 3)}");
Console.WriteLine($"5 * 3 = {Maths.Multiply(5, 3)}");

try
{
    Console.WriteLine($"5 / 0 = {Maths.Divide(5, 0)}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

try
{
    Console.WriteLine($"Площадь (-5, 10) = {Maths.RectangleArea(-5, 10)}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

Console.WriteLine($"\nКонстанта BINARY_FACTOR: {Maths.BINARY_FACTOR}");

Console.WriteLine("\nРабота с пользователями:");
User user = new("admin", "1234", Role.Администратор);
Console.WriteLine($"Логин: {user.Login}, Роль: {user.UserRole}");