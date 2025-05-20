public partial class TextFilterPage : ContentPage
{
    List<FileInfo> allFiles;

    public TextFilterPage()
	{
        InitializeComponent();
        LoadFiles();
    }
    void LoadFiles()
    {
        DirectoryInfo directory = new("Y:\\МДК.01.01");
        allFiles = directory.GetFiles().ToList();
        FileListView.ItemsSource = allFiles;
        UpdateInfoLabel(allFiles.Count, allFiles.Count);
    }

    void OnTextChanged(object sender, TextChangedEventArgs e)
    {
        var result = allFiles.Where(f => f.Name.Contains(e.NewTextValue, StringComparison.OrdinalIgnoreCase)).ToList();
        FileListView.ItemsSource = result;
        UpdateInfoLabel(result.Count, allFiles.Count);
    }

    void OnResetClicked(object sender, EventArgs e)
    {
        SearchEntry.Text = string.Empty;
        FileListView.ItemsSource = allFiles;
        UpdateInfoLabel(allFiles.Count, allFiles.Count);
    }

    void UpdateInfoLabel(int shown, int total)
    {
        InfoLabel.Text = $"Показано {shown} из {total} записей";
    }

    //void OnFilterChanged(object sender, EventArgs e)
    //{
    //    if (!long.TryParse(sizeEntry.Text, out long size))
    //        size = 0;

    //    var result = allFiles.AsEnumerable();

    //    if (GreaterRadio.IsChecked)
    //        result = result.Where(f => f.Length >= size);
    //    else if (LessRadio.IsChecked)
    //        result = result.Where(f => f.Length <= size);

    //    Update(result);
    //}

    void OnFilteredChanged(object sender, EventArgs e)
    {
        var result = allFiles.AsEnumerable();

        if (MinCheck.IsChecked && long.TryParse(MinEntry.Text, out long min))
            result = result.Where(f => f.Length >= min);

        if (MaxCheck.IsChecked && long.TryParse(MaxEntry.Text, out long max))
            result = result.Where(f => f.Length <= max);

        Update(result);
    }

    void DateFilterChanged(object sender, EventArgs e)
    {
        var result = allFiles.AsEnumerable();

        if (AfterCheckBox.IsChecked)
        {
            var selectedDate = DatePicker.Date;
            result = result.Where(f => f.LastWriteTime > selectedDate);
        }

        Update(result);
    }

    private void Update(IEnumerable<FileInfo> result)
    {
        var list = result.ToList();
        FileListView.ItemsSource = list;
        InfoLabel.Text = list.Any() ? $"Найдено: {list.Count}" : "Подходящих файлов не найдено";
    }
}
