// MainWindow
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ContentFrame.Navigate(new Pages.MainPage());
        Manager.MainFrame = ContentFrame;
    }
    private void BackButton_Click(object sender, RoutedEventArgs e)
    {
        if (Manager.MainFrame.CanGoBack)
            Manager.MainFrame.GoBack();
    }
    private void ContentFrame_ContentRendered(object sender, EventArgs e)
    {
        BackButton.Visibility = Manager.MainFrame.CanGoBack ? Visibility.Visible : Visibility.Collapsed;
    }
}

// AutorizationPage
public partial class AutorizationPage : Page
{
    public AutorizationPage()
    {
        InitializeComponent();
    }

    private void EnterButton_Click(object sender, RoutedEventArgs e)
    {

        Manager.MainFrame.GoBack();
    }

    private void RegistrationButton_Click(object sender, RoutedEventArgs e)
    {
        Manager.MainFrame.Navigate(new Pages.RegistrationPage());
    }   
}

// MainPage
public partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void AutorizationButton_Click(object sender, RoutedEventArgs e)
    {
        Manager.MainFrame.Navigate(new Pages.AutorizationPage());
    }

    private void RegistrationButton_Click(object sender, RoutedEventArgs e)
    {
        Manager.MainFrame.Navigate(new Pages.RegistrationPage());
    }

    private void SettingsButton_Click(object sender, RoutedEventArgs e)
    {
        Manager.MainFrame.Navigate(new Pages.SettingPage());
    }
}

// RegistrationPage
public partial class RegistrationPage : Page
{
    public RegistrationPage()
    {
        InitializeComponent();
    }

    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        Manager.MainFrame.GoBack();
    }
}

// SettingPage
public partial class SettingPage : Page
{
    public SettingPage()
    {
        InitializeComponent();
    }
    private void TabControl_Loaded(object sender, RoutedEventArgs e)
    {
        var categories = new Dictionary<string, List<string>>
        {
            { "Экшен", new List<string> { "CS", "Valorant" } },
            { "RPG", new List<string> { "Lost Ark", "Ark" } }
        };

        foreach (var category in categories)
        {
            Expander expander = new() { Header = category.Key };
            StackPanel innerPanel = new();

            foreach (var game in category.Value)
            {
                innerPanel.Children.Add(new CheckBox { Content = game });
            }

            expander.Content = innerPanel;
            GameStack.Children.Add(expander);
        }
    }
}
