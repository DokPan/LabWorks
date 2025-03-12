DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp34");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

if (!directory.Exists)
{
    Console.WriteLine("Директория не существует.");
    return;
}

var task1 = files
    .Select(f => new { f.Name, f.DirectoryName, f.Length, f.CreationTime })
    .OrderBy(f => f.Name)
    .ThenByDescending(f => f.CreationTime)
    .Dump();

var task2 = files
    .Where(f => f.Name.Contains("LabWork", StringComparison.OrdinalIgnoreCase))
    .Select(f => f.Name)
    .Dump();

int task2_2 = files.Count(f => f.Name.Equals("LabWork10.sln", StringComparison.OrdinalIgnoreCase))
    .Dump();

var task3 = files
    .Select(f => f.Extension)
    .Distinct()
    .Select(g => new { Extension = g.Key, Count = g.Count() })
    .Dump();

var task4 = files
    .Where(f => f.CreationTime.Date == DateTime.Today)
    .OrderByDescending(f => f.CreationTime)
    .Select(f => new { f.Name, f.CreationTime })
    .Take(10)
    .Dump();

var task5 = files
    .Select(f => new
    {
        f.Name,
        f.Extension,
        f.FullName,
        Size = f.Length < (1 << 10) ? $"{f.Length} Б" :
           f.Length < (1 << 20) ? $"{f.Length >> 10} КБ" :
           $"{f.Length >> 20} МБ"
    })
    .Dump();
