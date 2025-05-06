public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ChooseColorButton_Click(object sender, RoutedEventArgs e)
    {
        ColorDialogWindow picker = new();
        picker.Owner = this;
        if (picker.ShowDialog() == true)
            Background = new SolidColorBrush(picker.SelectedColor);
    }
}
