using Excel = Microsoft.Office.Interop.Excel;

// Задание 1
string filePath = "logins.csv";
Console.WriteLine("Введите логин:");
string login = Console.ReadLine().Trim();

while (IsLoginExists(login, filePath))
{
    Console.WriteLine("Логин уже существует. Введите другой:");
    login = Console.ReadLine().Trim();
}

Console.WriteLine("Введите пароль:");
string password = Console.ReadLine().Trim();

string newUser = $"{login};{password};{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
File.AppendAllText(filePath, newUser + Environment.NewLine);

Console.WriteLine("Пользователь успешно зарегистрирован!");

static bool IsLoginExists(string login, string filePath)
{
    if (!File.Exists(filePath)) return false;
    return File.ReadLines(filePath).Select(line => line.Split(';')[0]).Contains(login);
}

// Задание 2
Console.WriteLine("Введите путь к каталогу:");
string folderPath = Console.ReadLine();

if (!Directory.Exists(folderPath))
{
    Console.WriteLine("Папка не найдена!");
    return;
}

Excel.Application excelApp1 = new Excel.Application();
Excel.Workbook workbook1 = excelApp1.Workbooks.Add();
Excel.Worksheet sheet1 = workbook1.Sheets[1];
sheet1.Name = "Файлы";
Excel.Worksheet sheet2 = workbook1.Sheets.Add();
sheet2.Name = "Подпапки";

// Заголовки
sheet1.Cells[1, 1] = "№";
sheet1.Cells[1, 2] = "Имя файла";
sheet1.Cells[1, 3] = "Размер (КБ)";
sheet2.Cells[1, 1] = "№";
sheet2.Cells[1, 2] = "Имя подпапки";

// Запись файлов
var files = Directory.GetFiles(folderPath);
for (int i = 0; i < files.Length; i++)
{
    FileInfo file = new FileInfo(files[i]);
    sheet1.Cells[i + 2, 1] = i + 1;
    sheet1.Cells[i + 2, 2] = file.Name;
    sheet1.Cells[i + 2, 3] = file.Length / 1024;
}

// Запись папок
var directories = Directory.GetDirectories(folderPath);
for (int i = 0; i < directories.Length; i++)
{
    sheet2.Cells[i + 2, 1] = i + 1;
    sheet2.Cells[i + 2, 2] = new DirectoryInfo(directories[i]).Name;
}

string filSavePath = "files_info.xlsx";
workbook1.SaveAs(Path.GetFullPath(filSavePath));
workbook1.Close();
excelApp1.Quit();

// Задание 3
Excel.Application excelApp2 = new Excel.Application();
Excel.Workbook workbook2 = excelApp2.Workbooks.Add();
Excel.Worksheet sheet = workbook2.Sheets[1];
sheet.Name = "Умножение";

// Заголовок
Excel.Range title = sheet.Range["D10", "J10"];
title.Merge();
title.Value = "Таблица умножения";
title.Font.Bold = true;
title.Font.Italic = true;
title.Font.Size = 20;
title.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

// Заполнение таблицы умножения
for (int i = 2; i <= 9; i++)
{
    sheet.Cells[i + 9, 2] = i;
    sheet.Cells[10, i + 2] = i;

    // Цвет множителей
    sheet.Cells[i + 9, 2].Interior.Color = Excel.XlRgbColor.rgbLightBlue;
    sheet.Cells[10, i + 2].Interior.Color = Excel.XlRgbColor.rgbLightGreen;
}

for (int i = 2; i <= 9; i++)
{
    for (int j = 2; j <= 9; j++)
    {
        Excel.Range cell = sheet.Cells[i + 9, j + 2];
        cell.Value = i * j;
        cell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
    }
}

string fileSavePath2 = "multiplication.xlsx";
workbook2.SaveAs(Path.GetFullPath(fileSavePath2));
workbook2.Close();
excelApp2.Quit();
