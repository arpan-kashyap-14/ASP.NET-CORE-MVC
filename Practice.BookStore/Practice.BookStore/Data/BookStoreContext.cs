using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Practice.BookStore.Data
{
    public class BookStoreContext:IdentityDbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options):base(options)
        {

        }

        public DbSet<Books> Books { get; set; }

        public DbSet<Language> Language { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BookStore;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
