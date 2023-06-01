namespace Lab5.Models
{
    public class BookMoc
    {
        static List<Book> books = new List<Book> //static 3shan ay object yt5la2 mnha y4of al ta8yeer aly hy3melo al object altany
        {
               new Book{ BookId=1 ,Title="nn" , Description="bsbsb", Language="hdgdv" ,PublishedOn=DateTime.Now , Price=30, ImageUrl="mm" },
               new Book{ BookId=2 ,Title="nn" , Description="bsbsb", Language="hdgdv" ,PublishedOn=DateTime.Now , Price=30, ImageUrl="mm" },
               new Book{ BookId=3 ,Title="nn" , Description="bsbsb", Language="hdgdv" ,PublishedOn=DateTime.Now , Price=30, ImageUrl="mm" },
               new Book{ BookId=4 ,Title="nn" , Description="bsbsb", Language="hdgdv" ,PublishedOn=DateTime.Now , Price=30, ImageUrl="mm" },
               new Book{ BookId=5 ,Title="nn" , Description="bsbsb", Language="hdgdv" ,PublishedOn=DateTime.Now , Price=30, ImageUrl="mm" }
        };

        public List<Book> GetAllBooks() 
        { return books; }
        public Book GetBookById(int id)
        { return books.FirstOrDefault(x=>x.BookId==id); }
        public void AddBook(Book book)
        { books.Add(book); }

        public void UpdateBook(Book _book)
        {
           Book book= books.FirstOrDefault(x => x.BookId == _book.BookId);
            book.Title = _book.Title;
            book.Description = _book.Description;
            book.Language = _book.Language;
            book.PublishedOn = _book.PublishedOn;
            book.Price = _book.Price;
            book.ImageUrl = _book.ImageUrl;
        }
        public void DeleteBook(int id)
        {
            Book book = books.FirstOrDefault(x => x.BookId == id);
            books.Remove(book);
        }
    }
}
