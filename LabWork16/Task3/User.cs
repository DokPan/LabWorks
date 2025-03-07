class User
{
    public event EventHandler<InfoEventArgs> UserChanged;

    private string login;
    private string password;

    protected void OnUserChanged(string propertyName, string textError)
    {
        UserChanged?.Invoke(this, new InfoEventArgs(propertyName, textError));
    }

    public string Login
    {
        get => login;
        set
        {
            if (login != value)
            {
                login = value;
                string error = string.IsNullOrEmpty(value) ? "Логин не может быть пустым" : "";
                OnUserChanged(nameof(Login), error);
            }
        }
    }

    public string Password
    {
        get => password;
        set
        {
            if (password != value)
            {
                password = value;
                string error = value.Length < 6 || value.Length > 20 ? "Пароль от 6 до 20 символов" : "";
                OnUserChanged(nameof(Password), error);
            }
        }
    }
}
