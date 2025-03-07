class User
{
    private string login;
    private string password;

    public event EventHandler UserChanged;

    protected void OnUserChanged()
    {
        UserChanged?.Invoke(this, EventArgs.Empty);
    }

    public string Login
    {
        get => login;
        set
        {
            if (login != value)
            {
                login = value;
                OnUserChanged();
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
                OnUserChanged();
            }
        }
    }
}
