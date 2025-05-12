public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        CommandBindings.Add(new CommandBinding(
            ApplicationCommands.Save,
            SaveCommand_Executed));

        DateTimeTextBox.Text = DateTime.Today.ToShortDateString();
    }

    private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
    {
        SaveFile();
    }

    private void SaveFile()
    {
        if (string.IsNullOrWhiteSpace(MainTextBox.Text))
            return;

        SaveFileDialog saveFileDialog = new SaveFileDialog
        {
            Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
            DefaultExt = ".txt"
        };

        if (saveFileDialog.ShowDialog() == true)
        {
            MessageBox.Show("Файл сохранён");
            File.WriteAllText(saveFileDialog.FileName, MainTextBox.Text);
        }
    }

    private void MainTextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        CharCountText.Text = $"Символов: {MainTextBox.Text.Length}";
    }

    private void ToggleStatusBar_Click(object sender, RoutedEventArgs e)
    {
        MainStatusBar.Visibility = ((MenuItem)sender).IsChecked ? Visibility.Visible : Visibility.Collapsed;
    }

    private void ZoomInButton_Click(object sender, RoutedEventArgs e)
    {
        ZoomSlider.Value = ZoomSlider.Value + 10;
    }

    private void ZoomOutButton_Click(object sender, RoutedEventArgs e)
    {
        ZoomSlider.Value = ZoomSlider.Value - 10;
    }

    private void ZoomSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        ZoomTextBlock.Text = $"Масштаб: {(int)ZoomSlider.Value}";
    }

    private void ClearMenuItem_Click(object sender, RoutedEventArgs e)
    {
        MainTextBox.Clear();
    }

    private void ExitContextMenuItem_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void AlignButton_Checked(object sender, RoutedEventArgs e)
    {
        ToggleButton clickedButton = sender as ToggleButton;

        if (clickedButton == null)
            return;

        foreach (var child in ((ToolBar)clickedButton.Parent).Items)
        {
            if (child is ToggleButton button && button != clickedButton)
                button.IsChecked = false;
        }
    }
}
