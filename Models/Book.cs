
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    [Table("Book")]
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookId { get; set; }

        [Required(ErrorMessage="*")]  //constrain using data annotaion 
        public string Title { get; set; }

        [StringLength(300,MinimumLength=10)]
        public string Description { get; set; }

        public string Language { get; set; }

        [Required(ErrorMessage = "*") , DataType(DataType.Date), Display(Name ="Date published")]
        public DateTime PublishedOn { get; set; }

        [Required(ErrorMessage = "*"),Range(5,500)]//,DataType(DataType.Currency)]
        public int Price { get; set; }

        [Display(Name ="Image Url")]
        public string ImageUrl { get; set; }

        public virtual ICollection<BookAuthors> BookAuthors { get; set; } = new HashSet<BookAuthors>();
        public virtual ICollection<Tag> Tags { get;set; } = new HashSet<Tag>();
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual PriceOffer PriceOffer { get; set; }
    }
}
