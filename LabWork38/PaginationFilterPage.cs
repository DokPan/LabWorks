public partial class PaginationFilterPage : ContentPage
{
    private List<FileItem> allFiles = new();
    private List<FileItem> shownFiles = new();

    public int PageSize { get; set; } = 5;
    public int PagesCount { get; set; }

    public PaginationFilterPage()
	{
		InitializeComponent();
        LoadFiles();
        ShowNextPage();
    }

    private void LoadFiles()
    {
        DirectoryInfo directory = new("Y:\\МДК.01.01\\images");
        allFiles = directory.GetFiles()
            .OrderBy(f => f.Name)
            .Select(f => new FileItem
            {
                Name = f.Name,
                Length = f.Length,
                CreationDate = f.CreationTime
            })
            .ToList();
        PagesCount = (int)Math.Ceiling((double)allFiles.Count / PageSize);
    }

    private void ShowNextPage()
    {
        var next = allFiles
            .Skip(shownFiles.Count)
            .Take(PageSize)
            .AsEnumerable();
        shownFiles.AddRange(next);

        FilesListView.ItemsSource = null;
        FilesListView.ItemsSource = shownFiles;

        InfoLabel.Text = $"Показано {shownFiles.Count} из {allFiles.Count} записей. Всего страниц: {PagesCount}";

        LoadMoreButton.IsEnabled = shownFiles.Count < allFiles.Count;
    }

    private void OnLoadMoreClicked(object sender, EventArgs e)
    {
        ShowNextPage();
    }
}
