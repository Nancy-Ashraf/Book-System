using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    [Table("PriceOffer")]
    public class PriceOffer
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PriceOfferId { get; set; }

        public int NewPrice { get; set; }
        public string PromotionText { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
