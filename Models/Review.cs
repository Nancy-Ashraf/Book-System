using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    [Table("Review")]
    public class Review
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReviewId { get; set; }
        public string VoteName { get; set; }
        public string Comment { get; set; }
        public int NumStars { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
    
}
