User user = new();

user.UserChanged += (sender, e) =>
{
    User changedUser = sender as User;
    Console.WriteLine($"Изменены данные пользователя со следующим логином: {changedUser.Login}");
};

user.Login = "NewUser";
user.Password = "Password123";
