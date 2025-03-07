using System.ComponentModel;
using System.Runtime.CompilerServices;

class User : INotifyPropertyChanged
{
    private string login;
    private string password;

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName="")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public string Login
    {
        get => login;
        set
        {
            if (login != value)
            {
                login = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }
    }

}
