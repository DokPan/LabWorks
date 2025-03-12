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
    .ThenByDescending(x => x.CreationTime)
    //.Dump(); 
string searchText = "example";
var task2 = files
    .Where(x => x.Name.Contains(searchText))
    .Select(x => x.Name)
    //.Dump(); 

string fileName = "document.txt";
int task2_2 = files.Count(x => x.Name.Equals(fileName, StringComparison.OrdinalIgnoreCase))
    //.Dump(); 

var task3 = files
    .Select(x => x.Extension)
    .Distinct()
    //.Dump(); 

var task3_2 = files
    .GroupBy(x => x.Extension)
    .Select(y => new { Extension = y.Key, Count = y.Count() })
    //.Dump(); 

var today = DateTime.Today;
var task4 = files
    .Where(x => x.CreationTime.Date == today)
    .OrderByDescending(x => x.CreationTime)
    .Take(10)
    //.Dump(); 
    
var task5 = files.Select(x => new
{
    x.Name,
    x.Extension,
    x.FullName,
    Size = x.Length < (1 << 10) ? $"{x.Length} Б" :
           x.Length < (1 << 20) ? $"{x.Length >> 10} КБ" :
           $"{x.Length >> 20} МБ"
})
    //.Dump();
