public partial class AutorizationWindow : Window
{
    public AutorizationWindow()
    {
        InitializeComponent();
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        string login = LoginBox.Text;
        string password = PasswordBox.Password;

        if (login == "admin" && password == "qwerty")
        {
            Hide();
            AdminWindow adminWindow = new();
            adminWindow.ShowDialog();                
        }
        else if (login == "manager" && password == "12345")
        {
            Hide();
            ManagerWindow managerWindow = new();
            managerWindow.ShowDialog();                
        }
        else
        {
            MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        Show();
    }

}
