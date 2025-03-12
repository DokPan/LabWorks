DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp34");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

if (!directory.Exists)
{
    Console.WriteLine("Директория не существует.");
    return;
}

var task1 = files
    .Select(x => new { x.Name, x.DirectoryName, x.Length, x.CreationTime })
    .OrderBy(x => x.Name)
    .ThenByDescending(x => x.CreationTime);

task1.Dump(); // Вывод в LINQPad

// 5.2 LINQ-запрос: список файлов с указанным текстом в имени
string searchText = "example"; // Укажите искомый текст
var task2 = files
    .Where(x => x.Name.Contains(searchText))
    .Select(x => x.Name);

task2.Dump();

// 5.2 LINQ-запрос: количество файлов с указанным названием
string fileName = "document.txt"; // Укажите искомое имя файла
int task2_2 = files.Count(x => x.Name.Equals(fileName, StringComparison.OrdinalIgnoreCase));

task2.Dump();

// 5.3 LINQ-запрос: список расширений файлов без повторений
var task3 = files
    .Select(x => x.Extension)
    .Distinct();

task3.Dump();

// 5.3 LINQ-запрос: список расширений и количество файлов каждого расширения
var task3_2 = files
    .GroupBy(x => x.Extension)
    .Select(y => new { Extension = y.Key, Count = y.Count() });

task3_2.Dump();

// 5.4 LINQ-запрос: последние 10 файлов, созданных за текущий день
var today = DateTime.Today;
var task4 = files
    .Where(x => x.CreationTime.Date == today)
    .OrderByDescending(x => x.CreationTime)
    .Take(10);

task4.Dump();

// 5.5 LINQ-запрос: имя файла, расширение, путь, размер с единицей измерения
var task5 = files.Select(x => new
{
    x.Name,
    x.Extension,
    x.FullName,
    Size = x.Length < (1 << 10) ? $"{x.Length} Б" :
           x.Length < (1 << 20) ? $"{x.Length >> 10} КБ" :
           $"{x.Length >> 20} МБ"
});

task5.Dump();
