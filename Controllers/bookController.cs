using Microsoft.AspNetCore.Mvc;
using hw.Services;
using hw.Interfaces;

namespace hw.Controllers;

[ApiController]
[Route("[controller]")]
public class bookController : ControllerBase
{

 private IbookService bookService;

    public bookController(IbookService bookService)
    {
        this.bookService=bookService;
        
    }
    

    [HttpGet]
    public IEnumerable<book> Get()
    {
       bookService.GetAll();
    }


    [HttpGet("{name}")]
    public IEnumerable<book> Get(string name)
    {
          var res = bookService.Get(name); 

        if (res == null)
            return NotFound();
        
        return res;
    }


    [HttpPost]
    public IActionResult Add(book book){
        bookService.Add(book);
        return CreatedAtAction(nameof(Add), book);
    }

    [HttpPut("{name}")]
    public IActionResult Update(String name,book book){
     if(bookService.Get(name)==null)
        return NotFound();
        bookService.Update(String name,book book);
        return CreatedAtAction(nameof(Update), book);
    }

    [HttpDelete("{name}")]
    public IActionResult Delete(String name){
       if(bookService.Get(name)==null)
        return NotFound();
        bookService.Delete(String name);
        return CreatedAtAction(nameof(Delete), book);
    }
}
