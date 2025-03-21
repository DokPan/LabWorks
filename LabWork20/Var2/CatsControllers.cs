using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
[ApiController]
[Route("api/cats/[controller]")]
public class CatsController : ControllerBase
    {
        private static List<Cat> cats = [
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
    //3.1.1
    [HttpGet]
    public IActionResult GetAllCats(int page = 1, int pageSize = 5)
    {
        return Ok(cats.Skip((page - 1) * pageSize).Take(pageSize));
    }

    //3.1.2
    [HttpGet("{id:int}")]
    public IActionResult GetCatById(int id)
    {
        var cat = cats.FirstOrDefault(c => c.Id == id);
        if (cat == null)
            return NotFound();
        return Ok(cat);
    }

    //3.2
    [HttpGet("{breed}")]
    public IActionResult GetCatsByBreed(string breed)
    {
        var filteredCats = cats.Where(c => c.Breed.Equals(breed, System.StringComparison.OrdinalIgnoreCase));
        if (!filteredCats.Any())
            return NotFound();
        return Ok(filteredCats);
    }

    //3.4
    [HttpDelete("{id}")]
    public IActionResult DeleteCat(int id)
    {
        var cat = cats.FirstOrDefault(c => c.Id == id);
        if (cat == null)
            return NotFound();
        cats.Remove(cat);
        return NoContent();
    }

    //3.5
    [HttpPost]
    public IActionResult AddCat(Cat cat)
    {
        cats.Add(cat);
        return CreatedAtAction(nameof(GetCatById), new { id = cat.Id }, cat);
    }
}
