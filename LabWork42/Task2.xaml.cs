public partial class Task2 : Window
{
    private List<string> images;
    private int currentIndex = 0;
    private DispatcherTimer timer;

    public Task2()
    {
        InitializeComponent();

        var dialog = new OpenFileDialog
        {
            Filter = "Image Files|*.jpg;*.png;*.bmp",
            Multiselect = false
        };

        if (dialog.ShowDialog() == true)
        {
            var folderPath = Path.GetDirectoryName(dialog.FileName);
            images = new List<string>(Directory.GetFiles(folderPath, "*.jpg"));

            if (images.Count == 0)
            {
                MessageBox.Show("В выбранной папке нет изображений.");
                return;
            }

            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(0.5)
            };
            timer.Tick += (s, e) => NextImage();
            timer.Start();
        }
    }

    private void NextImage()
    {
        CarouselImage.Source = new BitmapImage(new Uri(images[currentIndex]));
        currentIndex = (currentIndex + 1) % images.Count;
    }
}

# XAML
/*
<Grid>
    <Image Name="CarouselImage" Stretch="Uniform"/>
</Grid>
*/
