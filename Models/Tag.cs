using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TagId { get; set; }

        public virtual ICollection<Book> Books { get; set; }= new HashSet<Book>();
    }
}
