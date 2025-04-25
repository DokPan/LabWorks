// Task1
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void CheckBox_CheckedChanged(object sender, RoutedEventArgs e)
    {
        SubscribeButton.IsEnabled = (sender as CheckBox).IsChecked == true;
    }
}

// Task2
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ShowPassword_Checked(object sender, RoutedEventArgs e)
    {
        if ((sender as CheckBox).IsChecked == true)
        {
            PasswordVisible.Text = PasswordHidden.Password;
            PasswordHidden.Visibility = Visibility.Collapsed;
            PasswordVisible.Visibility = Visibility.Visible;
        }
        else
        {
            PasswordHidden.Password = PasswordVisible.Text;
            PasswordVisible.Visibility = Visibility.Collapsed;
            PasswordHidden.Visibility = Visibility.Visible;
        }
    }
}
// Task3, Task4
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void FontSizeRadioButton_Checked(object sender, RoutedEventArgs e)
    {
        if ((sender as RadioButton) != null && int.TryParse((sender as RadioButton).Content.ToString(), out int size))
            InputTextBox.FontSize = size;
    }

    private void AlignLeftRadioButton_Checked(object sender, RoutedEventArgs e) => InputTextBox.TextAlignment = TextAlignment.Left;
    private void AlignCenterRadioButton_Checked(object sender, RoutedEventArgs e) => InputTextBox.TextAlignment = TextAlignment.Center;
    private void AlignRightRadioButton_Checked(object sender, RoutedEventArgs e) => InputTextBox.TextAlignment = TextAlignment.Right;
}

// Task5
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ColorSlider_Changed(object sender, RoutedEventArgs e)
    {
        if (RedCheckBox == null || GreenCheckBox == null || BlueCheckBox == null)
            return;

        byte red = RedCheckBox.IsChecked == true ? (byte)RedSlider.Value : (byte)0;
        byte green = GreenCheckBox.IsChecked == true ? (byte)GreenSlider.Value : (byte)0;
        byte blue = BlueCheckBox.IsChecked == true ? (byte)BlueSlider.Value : (byte)0;

        Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
    }
}
