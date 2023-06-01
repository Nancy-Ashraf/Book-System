using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    [Table("Author")]
    public class Author
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AuthorId { get; set; }
        
        [Required]
        public string Name { get; set; }

        public virtual ICollection<BookAuthors> BookAuthors { get; set; } = new HashSet<BookAuthors>();

    }
}
