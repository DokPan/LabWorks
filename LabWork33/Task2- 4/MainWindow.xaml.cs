public partial class MainWindow : Window
{
    public List<User> Users { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        Users = new List<User>
        {
            new User { Address = "user1@mail.ru", Login = "user1", Password = "password1", Category = "email", Archived = true },
            new User { Address = "user2@mail.com", Login = "user2", Password = "password2", Category = "сайт", Archived = false },
            new User { Address = "user3@gmail.ru", Login = "user3", Password = "password3", Category = "сайт", Archived = true },
            new User { Address = "user2@mail.com", Login = "user4", Password = "pass4word", Category = "email", Archived = false },
            new User { Address = "user5@gmail.com", Login = "user5", Password = "password5", Category = "БД", Archived = false }
        };
        UsersDataGrid.ItemsSource = Users;
    }

    private void CopyPasswordButton_Click(object sender, RoutedEventArgs e)
    {
        var user = (sender as Button).DataContext as User;

        if (user != null)
            SetDataFile(user.Password);
    }

    private void SetDataFile(string password)
    {
        MessageBox.Show("Пароль скопирован в буфер обмена.");
    }
}
