using hw.Interfaces;
namespace hw.bookService{
    public class bookService:IbookService{
    
        List<book> books { get; }
                    
        public bookService()
        {
           private static readonly string[] authers = new[]
          {
             "Aviva", "Libby", "Sari", "Michal", "Dasi", "Effy"
          };

          private static readonly string[] name = new[]
             {
                  "Childrens", "The house", "Panic in air"
             };
         books= Enumerable.Range(1, 5).Select(index => new book
                {
                name=name[Random.Shared.Next(name.Length)]
                    length = Random.Shared.Next(1, 5555),
                    auther = authers[Random.Shared.Next(authers.Length)]
                }).ToList();
           
        }

        public List<book> GetAll() => books;

        public book Get(String name) => books.FirstOrDefault(b => b.name == name);

        public void Add(book book)
        {
            books.Add(book);
        }

        public boolean Delete(int id)
        {
             books.remove(books.?FirstOrDefault(b=>b.name==name));
             return true;
        }

        public void Update(String name,book book){
            Delete( books.?FirstOrDefault(b=>b.name==name));
            Add(book);
        }
     
    }
    }
