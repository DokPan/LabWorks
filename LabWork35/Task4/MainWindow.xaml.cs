public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OpenButton_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog dialog = new();
        dialog.Filter = "Изображения (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
        dialog.Multiselect = true;

        if (dialog.ShowDialog() != true)
            return;

        var imagePaths = new List<BitmapImage>();
            foreach (var path in dialog.FileNames)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new System.Uri(path);
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();
                imagePaths.Add(bitmap);
            }

            ImageListView.ItemsSource = imagePaths;
    }
}
