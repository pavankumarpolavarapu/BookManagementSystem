using BookManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Models {
    public class AppDbContext : DbContext {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base (options) {

        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Patron> Patron { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
    }
}