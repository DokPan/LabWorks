using System.Text;
Console.WriteLine("Введите строку: ");
string input = Console.ReadLine();
int lenght = input.Length;
Console.WriteLine($"Количество символов: {lenght}");

int symbolsWithoutSpaces = input.Replace(" ", "").Length;
Console.WriteLine($"Количество символов без пробелов: {symbolsWithoutSpaces}");

int lettersCount = 0;
foreach (char c in input)
{
    if (char.IsLetter(c))
        lettersCount++;
}
Console.WriteLine($"Количество букв в строке: {lettersCount}");
Console.WriteLine("Введите символ для поиска: ");

char searchSymbol = Console.ReadKey().KeyChar;
Console.WriteLine();

List<int> positions = new();
for (int i = 0; i < lenght; i++)
{
    if (input[i] == searchSymbol)
        positions.Add(i);
}
if (positions.Count > 0)
    Console.WriteLine($"Символ {searchSymbol} найден на позиции {string.Join(",", positions)}");
else
    Console.WriteLine("Символ не найден");

while (input.Contains("  "))
{
    input = input.Replace("  ", " ");
}
Console.WriteLine($"Строка без пробелов: {input.Trim()}");

Console.WriteLine("Выберите регистр (upper, lower, invert): ");
string option = Console.ReadLine();
StringBuilder sb = new();
foreach (char c in input)
{
    if (option == "upper")
        sb.Append(char.ToUpper(c));
    else if (option == "lower")
        sb.Append(char.ToLower(c));
    else if (option == "invert")
        sb.Append(char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
}
Console.WriteLine($"Изменённая строка: {sb}");

Console.Write("Введите текст: ");
string text = Console.ReadLine();
while (text.Contains("!!") || text.Contains("??") || text.Contains(".."))
{
    text = text.Replace("!!", "!");
    text = text.Replace("??", "?");
    text = text.Replace("..", ".");
}
string[] sentences = text.Split(new[] { '!', '?', '.' });
Console.WriteLine("Предложения:");
Console.WriteLine(string.Join("\n", sentences));

Product product1 = new Product { Name = "молоко", Price = 99.99, ExpirationDate = new DateTime(2025, 03, 08) };
Console.WriteLine(product1);

string[] strings = { "Привет, мир", "Добрый день", "Приятного аппетита", "Солнечная погода" };
Console.Write("Введите текст для поиска в начале строки: ");
string startText = Console.ReadLine();
var filteredStart = strings
    .Where(p => p.StartsWith(startText, StringComparison.OrdinalIgnoreCase))
    .ToArray();
Console.WriteLine(filteredStart.Length > 0 ? string.Join("\n", filteredStart) : "Совпадений не найдено.");
