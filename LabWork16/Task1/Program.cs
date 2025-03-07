User user = new();
user.PropertyChanged += (sender, e) =>
{
    Console.WriteLine($"Изменено свойство {e.PropertyName}");
};

user.Login = "NewUser";
user.Password = "Password123";
