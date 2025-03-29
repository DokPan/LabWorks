Console.Write("Введите файл для перемещения: ");
string folderPath = Console.ReadLine();
Console.Write("Введите путь к папке: ");
string searchPath = Console.ReadLine();

if (!Directory.Exists(folderPath))
{
    Console.WriteLine("Указанная папка не существует.");
    return;
}

string[] searchFiles = Directory.GetFiles(folderPath);
foreach (string file in searchFiles)
{
    FileInfo fileInfo = new (file);
    DateTime lastModified = fileInfo.LastWriteTime;

    string newFolderPath = Path.Combine(folderPath, lastModified.Year.ToString(),
                                        lastModified.Month.ToString("D2"),
                                        lastModified.Day.ToString("D2"));

    Directory.CreateDirectory(newFolderPath);

    string newFilePath = Path.Combine(newFolderPath, fileInfo.Name);
    File.Move(file, newFilePath);

    Console.WriteLine($"Файл перемещен: {newFilePath}");
}

Console.WriteLine("Все файлы отсортированы по датам изменения.");
