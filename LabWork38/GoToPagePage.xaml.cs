public partial class GoToPagePage : ContentPage
{
    private List<FileItem> allFiles = new();

    public int PageSize { get; set; } = 2;
    public int PagesCount { get; set; }
    public int CurrentPage { get; set; } = 0;

    public string PageInfo => $"Показано {CurrentPage} из {PagesCount} страниц";

    public GoToPagePage()
    {
        InitializeComponent();
        LoadFiles();
        DisplayCurrentPage(1);
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

    private void DisplayCurrentPage(int pageNumber)
    {
        CurrentPage = pageNumber;
        var filesToDisplay = allFiles.Skip((pageNumber - 1) * PageSize).Take(PageSize).ToList();

        FilesListView.ItemsSource = filesToDisplay;
        InfoLabel.Text = $"Показано {CurrentPage} из {PagesCount} страниц";
    }
    private void OnPreviousPageClicked(object sender, EventArgs e)
    {
        if (CurrentPage > 0)
            DisplayCurrentPage(CurrentPage-1);
    }

    private void OnNextPageClicked(object sender, EventArgs e)
    {
        if (CurrentPage < PagesCount)
            DisplayCurrentPage(CurrentPage+1);
    }

    private void OnFirstPageClicked(object sender, EventArgs e)
    {
        DisplayCurrentPage(1);
    }

    private void OnLastPageClicked(object sender, EventArgs e)
    {
        DisplayCurrentPage(PagesCount);
    }

    private void OnPageEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        if (int.TryParse(e.NewTextValue, out int pageNumber))
        {
            
            if (pageNumber >= 1 && pageNumber <= PagesCount)
            {
                DisplayCurrentPage(pageNumber);
            }
        }
    }
}
