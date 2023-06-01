using Lab5.Services;

namespace Lab5.Models
{
    public class BookDB:IEntity<Book>
    {
        Context DB;
        public BookDB(Context _DB)
        {
            DB = _DB;
        }
        public List<Book> GetAll()
        {
            return DB.Books.ToList();
        }
        public Book GetById(int id)
        {
            return DB.Books.FirstOrDefault(book =>book.BookId == id);
        }
        public Book Add(Book book)
        {
            DB.Books.Add(book);
            DB.SaveChanges();
            return book;
        }
        public Book Update(Book book)
        {
            Book b1=DB.Books.FirstOrDefault(b=>b.BookId == book.BookId);
            b1.Title = book.Title;
            b1.Description = book.Description;
            b1.PublishedOn = book.PublishedOn;
            b1.Price = book.Price;
            b1.ImageUrl = book.ImageUrl;
            DB.SaveChanges();
            return b1;
        }
        public void DeleteById(int id)
        {
            Book b1=DB.Books.FirstOrDefault(b => b.BookId == id);
            DB.Books.Remove(b1);
            DB.SaveChanges();
        }
    }
}
