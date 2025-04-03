using Microsoft.Office.Interop.Word;
try
{
    Console.WriteLine("Введите текст для документа:");
    string inputText = Console.ReadLine();

    Console.WriteLine("Введите количество заданий:");
    int taskCount = int.Parse(Console.ReadLine());

    // Запуск Word
    Application wordApp = new Application();
    Document doc = wordApp.Documents.Add();

    // Форматирование документа
    SetDocumentFormatting(doc);

    // Вставка текста
    Paragraph para = doc.Paragraphs.Add();
    para.Range.Text = inputText;
    para.Range.InsertParagraphAfter();

    // Вставка таблицы
    InsertTaskTable(doc, taskCount);

    // Вставка даты
    InsertDate(doc);

    // Вставка изображения
    InsertImage(doc);

    // Сохранение документа
    Console.WriteLine("Введите путь для сохранения файла (без расширения):");
    string filePath = Console.ReadLine();

    Console.WriteLine("Выберите формат (1 - DOCX, 2 - PDF):");
    int formatChoice = int.Parse(Console.ReadLine());

    if (formatChoice == 1)
        doc.SaveAs2(filePath + ".docx", WdSaveFormat.wdFormatDocumentDefault);

    else if (formatChoice == 2)
        doc.SaveAs2(filePath + ".pdf", WdSaveFormat.wdFormatPDF);

    else
    {
        Console.WriteLine("Некорректный формат, файл сохранён в DOCX.");
        doc.SaveAs2(filePath + ".docx", WdSaveFormat.wdFormatDocumentDefault);
    }

    doc.Close();
    wordApp.Quit();

    Console.WriteLine("Документ успешно создан и сохранён!");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
static void SetDocumentFormatting(Document doc)
{
    doc.Styles["Normal"].Font.Name = "Times New Roman";
    doc.Styles["Normal"].Font.Size = 14;
    doc.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
}

static void InsertTaskTable(Document doc, int taskCount)
{
    doc.Content.InsertParagraphAfter();
    Paragraph para = doc.Paragraphs.Add();
    para.Range.Text = "Таблица 1 — Задания";
    para.Range.InsertParagraphAfter();

    Table table = doc.Tables.Add(para.Range, taskCount + 1, 2);
    table.Borders.Enable = 1;

    table.Cell(1, 1).Range.Text = "№";
    table.Cell(1, 2).Range.Text = "Текст";

    for (int i = 1; i <= taskCount; i++)
    {
        table.Cell(i + 1, 1).Range.Text = i.ToString();
        table.Cell(i + 1, 2).Range.Text = "";
    }
}

static void InsertDate(Document doc)
{
    Paragraph para = doc.Paragraphs.Add();
    para.Range.Text = $"Дата создания: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
    para.Range.InsertParagraphAfter();
}

static void InsertImage(Document doc)
{
    string imagePath = @"C:\Users\79009\Pictures\Saved Pictures\04133e86e76c9f052d27d7d693d7d05c.jpg";
    if (File.Exists(imagePath))
    {
        InlineShape shape = doc.InlineShapes.AddPicture(imagePath);
        shape.Width = 100;
        shape.Height = 50;
    }
    else
        Console.WriteLine("Изображение не найдено, пропускаем вставку.");
}
