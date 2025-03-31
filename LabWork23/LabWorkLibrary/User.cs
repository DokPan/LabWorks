/// <summary>Класс пользователя с логином, паролем и ролью</summary>
public class User
{
    /// <summary>Логин пользователя</summary>
    public string Login { get; set; }

    /// <summary>Пароль пользователя</summary>
    public string Password { get; set; }

    /// <summary>Роль пользователя</summary>
    public Role UserRole { get; set; }

    /// <summary>Создает нового пользователя</summary>
    /// <param name="login">Логин</param>
    /// <param name="password">Пароль</param>
    /// <param name="role">Роль</param>
    public User(string login, string password, Role role)
    {
        Login = login;
        Password = password;
        UserRole = role;
    }
}
