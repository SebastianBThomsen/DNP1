using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DataAccess
{
    public class LibraryDBContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = C:/Users/Bruger/Desktop/VIA/SoftwareEngineer/3. Semester/DNP/DNP1/Session9_Database/Library/Library.db");
        }
    }
}