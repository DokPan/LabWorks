public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
        var files = new DirectoryInfo(@"Y:\МДК.01.01").GetFiles();
        FilesListView.ItemsSource = files;
    }

    private void InfoButton_Click(object sender, RoutedEventArgs e)
    {
        var fileInfo = (sender as Button).DataContext as FileInfo;

        if (fileInfo != null)
            MessageBox.Show($"Полное имя файла: {fileInfo.FullName}");
    }
}
