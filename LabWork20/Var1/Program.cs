var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

List<Cat> cats = [
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
];


//3.1.2
app.MapGet("/cats/{id:int}", (int id) =>
    cats.FirstOrDefault(x => x.Id == id) is Cat cat ? Results.Ok(cat): Results.NotFound()
);

//3.2
app.MapGet("/cats/{breed}", (string breed) =>
{
    var filteredCats = cats.Where(c => c.Breed.Equals(breed, StringComparison.OrdinalIgnoreCase));
    if (!filteredCats.Any())
        return Results.NotFound();
    return Results.Ok(filteredCats);
});

//3.3
int pageSize = 5;
app.MapGet("/cats", (int page = 1) =>
{
    return Results.Ok(cats.Skip((page - 1) * pageSize).Take(pageSize));
});

//3.4
app.MapDelete("/cats/{id}", (int id) =>
{
    var cat = cats.FirstOrDefault(c => c.Id == id);
    if (cat == null)
        return Results.NotFound();
    cats.Remove(cat);
    return Results.NoContent();
});

//3.5
app.MapPost("/cats", (Cat cat) =>
{
    cats.Add(cat);
    return Results.Created($"/cats/{cat.Id}",cat);
});

app.Run();
