namespace hw.Interfaces;
 public interface IbookService{
        List<book> GetAll();

        book Get(String name);

        void Add(book book);

        void Delete(String name);

        void Update(String name, book book);

       
 }