public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

    }

    private void NewWindowMenuItem_Click(object sender, RoutedEventArgs e)
    {
        MainWindow window = new();
        window.Show();
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        ConfirmWindow confirm = new();
        confirm.Owner = this;
        confirm.WindowStartupLocation = WindowStartupLocation.CenterOwner;

        if (confirm.ShowDialog() != true)
            e.Cancel = true;
    }
}
