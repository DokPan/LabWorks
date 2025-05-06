public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void PrintButton_Click(object sender, RoutedEventArgs e)
    {
        PrintDialog dialog = new();

        if (dialog.ShowDialog() == true)
            return;

        dialog.PrintVisual(CatCanvas, "Печать Canvas");
    }
}
