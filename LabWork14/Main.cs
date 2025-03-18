using System.Text.RegularExpressions;

//77(900)123-45-67
string pattern = @"^(\+7|8)\(9\d{2}\)\d{3}-\d{2}-\d{2}$";
Console.Write("Введите номер телефона: ");
string phone = Console.ReadLine();
if (Regex.IsMatch(phone, pattern))
    Console.WriteLine("Номер телефона корректный.");
else
    Console.WriteLine("Некорректный номер телефона.");

//hi world     !
Console.Write("Введите строку: ");
string input = Console.ReadLine();
string result = Regex.Replace(input, @"\s{2,}", " ");
Console.WriteLine($"Результат: {result}");

//Papirap@papirap.papirap.ru
string patternEmail = @"^[A-Za-z0-9_-]+@[A-Za-z0-9-.]*\.[A-Za-z]+$";
Console.Write("Введите email: ");
string email = Console.ReadLine();
if (Regex.IsMatch(email, patternEmail, RegexOptions.IgnoreCase))
    Console.WriteLine("Email корректный.");
else
    Console.WriteLine("Некорректный email.");

//Papirap34.345
string patternPassword = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[.?!]).{6,}$";
while (true)
{
    Console.Write("Введите пароль: ");
    string password = Console.ReadLine();
    if (Regex.IsMatch(password, patternPassword))
    {
        Console.WriteLine("Пароль надежен.");
        break;
    }
    else
        Console.WriteLine("Пароль не соответствует требованиям! Попробуйте снова.");
}

//12.12.12 13/14/1978
string patternData = @"\b(?<day>\d{1,2})[./](?<month>\d{1,2})[./](?<year>\d{2,4})\b";
Console.Write("Введите строку с датами: ");
string data = Console.ReadLine();
string resultData = Regex.Replace(data, patternData, match =>
{
    string day = int.Parse(match.Groups["day"].Value).ToString("D2");
    string month = int.Parse(match.Groups["month"].Value).ToString("D2");
    string year = match.Groups["year"].Value.Length == 2 ? "20" + match.Groups["year"].Value : match.Groups["year"].Value;

    return $"{year}-{month}-{day}";
});
Console.WriteLine($"Преобразованная строка: {resultData}");
