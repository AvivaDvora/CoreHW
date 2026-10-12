using Microsoft.AspNetCore.Mvc;

namespace hw.Controllers;

[ApiController]
[Route("[controller]")]
public class bookController : ControllerBase
{
    private static readonly string[] authers = new[]
    {
        "Aviva", "Libby", "Sari", "Michal", "Dasi", "Effy"
    };
   private static readonly string[] name = new[]
    {
        "Childrens", "The house", "Panic in air"
    };
      private static List<book>? arr;

    public bookController()
    {
        arr = Enumerable.Range(1, 5).Select(index => new book
        {
           name=name[Random.Shared.Next(name.Length)]
            length = Random.Shared.Next(1, 5555),
            auther = authers[Random.Shared.Next(authers.Length)]
        }).ToList();
    }
    }

    [HttpGet]
    public IEnumerable<book> Get()
    {
        return arr;
    }
    [HttpGet("{name}")]
    public IEnumerable<book> Get(string name)
    {
          var res = arr?.FirstOrDefault(w => w.name == name); 

        if (res == null)
            return NotFound();
        
        return res;
    }
}
