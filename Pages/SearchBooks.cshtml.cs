using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace BookManagement.Pages {
    public class SearchBooksModel : PageModel {
        private AppDbContext _context;

        [BindProperty]
        public string Search { get; set; }
        public bool SearchCompleted { get; set; }
        public ICollection<Book> SearchResults { get; set; }

        public SearchBooksModel (AppDbContext context) {
            _context = context;
        }
        public void OnGet () {
            SearchCompleted = false;
        }

        public void OnPost () {
            // PERFORM SEARCH
            if (string.IsNullOrWhiteSpace (Search)) {
                // EXIT EARLY IF THERE IS NO SEARCH TERM PROVIDED
                return;
            }
            SearchResults = _context.Book
                .Include (r => r.Reservations).ThenInclude(p => p.Patron)
                .Where (b => b.Title.ToLower ().Contains (Search.ToLower ()))
                .ToList ();
            SearchCompleted = true;
        }
    }
}