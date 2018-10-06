using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookManagement.Models;

namespace BookManagement.Pages {
    public class BooksByGenreModel : PageModel {
        private readonly BookManagement.Models.AppDbContext _context;
        public string _Genre { get; set; }
        public ICollection<Book> Books { get; set; }
        public BooksByGenreModel (BookManagement.Models.AppDbContext context) {
            _context = context;
        }
        public void OnGet (string Genre) { 
            _Genre = Genre;
            Books = _context.Book
                            .Where( b => b.Genre == Genre)
                            .ToList();
        }
    }
}