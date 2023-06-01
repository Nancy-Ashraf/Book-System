using Microsoft.EntityFrameworkCore;

namespace Lab5.Models
{

    public class Context : DbContext
    {

        public Context()
        {

        }
        public Context(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual BookAuthors BookAuthors { get; set; }
        public virtual DbSet<PriceOffer> PricesOffers { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthors>()
                .HasKey(x => new { x.OrderId, x.BookId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
