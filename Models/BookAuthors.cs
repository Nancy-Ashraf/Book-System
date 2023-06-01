using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    [Table("BookAuthor")]
    public class BookAuthors
    {
        [ForeignKey("Book")]
        public int BookId { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public int OrderId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }
    }
}
