User user = new();

user.UserChanged += (sender, e) =>
{
    User changedUser = sender as User;
    Console.WriteLine($"{e.ChangedDate}: у пользователя {changedUser.Login} изменено {e.PropertyName}");
    if (!string.IsNullOrEmpty(e.TextError))
        Console.WriteLine($"Ошибка: {e.TextError}");
};

user.Login = "";
user.Password = "Password123";
