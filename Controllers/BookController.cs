using Lab5.Models;
using Lab5.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Lab5.Controllers
{

    public class BookController : Controller
    {
        //IEntity<BookController> DB;
         BookMoc books = new BookMoc(); 
        public ViewResult Index()
        {
            //ViewData.Model= books;
            //return new ViewResult { ViewName = "index" , ViewData = ViewData, };
            return View(books.GetAllBooks());
        }

        [HttpPost] //action selector
        public IActionResult Create(Book _book) //==(int BookId, string Title, string Description, string Language, DateTime PublishedOn, int Price, string ImageUrl)
        #region Notes
        //here the data in the parameters is filled using model binder w law al data mesh mawgoda hy7ot al default bta3ha
        // if we use object as a parameter -> model binder will search in data get by ( querystring or ...) for (objectName.properyName -> book.id) or (propertyName only -> id) as it put in (name="") at the form and then will bind it 

        #endregion
        {
            //Book book = new Book() { BookId = BookId, Title = Title, Description = Description, Language = Language, PublishedOn = PublishedOn, Price = Price, ImageUrl = ImageUrl };
            if(ModelState.IsValid)
            {
                books.AddBook(_book);
               return RedirectToAction("Index");
            }
            else
            {
                return View(_book);
            }
        }

        [HttpGet] //action selector
        public IActionResult Create()
        {
            return View();
        }
        #region Notes
        //1)
        //ViewResult && RedirectToActionResult Both implement IActionResult
        //so we can return IAction result in the both cases
        //2)
        //priority of getting the data BY The model binder
        //1-from -> posted data
        //2-routing data
        //3- query string 
        //we may not depend on the periority -> ex:[FromForm]int BookId or [FromQuery]int BookId and so on
        #endregion

        public IActionResult Details(int? id) //must be called id as it get by the routing system
        {
            if(id is null)
            {
                return BadRequest();  //400
            }
            Book book = books.GetBookById(id.Value);
            if (book is null)
            {
                return NotFound(); //404
            }
            return View(book);
            
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id is null)
            {
                return BadRequest();
            }
            Book book = books.GetBookById(id.Value);
            if (book is null)
            {
                return NotFound(); //404
            }
            return View(book);
        }

        [HttpPost]
        public IActionResult Update(Book book)
        {
            books.UpdateBook(book);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Book book = books.GetBookById(id);
            return View(book);
        }
       
        
        
        [HttpPost]//,ActionName("Delete")]
        public IActionResult Delete(int? bookId)
        {
            if (bookId is null)
            {
                return BadRequest();
            }
            Book book = books.GetBookById(bookId.Value);
            if (book is null)
            {
                return NotFound(); //404
            }
            books.DeleteBook(bookId.Value);
            return RedirectToAction("Index");
        }

    }
}
