using System.Text;

// Class
public class Cat
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
}
//

List<Cat> cats = new List<Cat>
{
    new Cat { Id = 1, Name = "Усатик", Breed = "Персидская", Color = "Белый", Age = 5 },
    new Cat { Id = 2, Name = "Варежка", Breed = "Сиамская", Color = "Сил-пойнт", Age = 3 },
    new Cat { Id = 3, Name = "Дымок", Breed = "Британская короткошерстная", Color = "Серый", Age = 7 },
    new Cat { Id = 4, Name = "Белла", Breed = "Мейн-кун", Color = "Рыжий", Age = 4 },
    new Cat { Id = 5, Name = "Макс", Breed = "Рэгдолл", Color = "Сил-миттед", Age = 2 },
    new Cat { Id = 6, Name = "Луна", Breed = "Персидская", Color = "Трехцветный", Age = 6 },
    new Cat { Id = 7, Name = "Оливер", Breed = "Британская короткошерстная", Color = "Черный", Age = 8 },
    new Cat { Id = 8, Name = "Клео", Breed = "Сиамская", Color = "Коричневый", Age = 3 },
    new Cat { Id = 9, Name = "Симба", Breed = "Мейн-кун", Color = "Рыжий", Age = 5 },
    new Cat { Id = 10, Name = "Ромашка", Breed = "Персидская", Color = "Белый", Age = 2 }
};

string result = ConvertCatsToString(cats);
Console.WriteLine(result);

string ConvertCatsToString(List<Cat> cats)
{
    StringBuilder sb = new();
    sb.AppendLine("Id;Name;Breed;Color;Age");
    foreach (var cat in cats)
        sb.AppendLine($"{cat.Id};{cat.Name};{cat.Breed};{cat.Color};{cat.Age}");
    return sb.ToString();
}
