using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookManagement.Pages.Reservations {
    public class CreateModel : PageModel {
        private readonly BookManagement.Models.AppDbContext _context;

        public CreateModel (BookManagement.Models.AppDbContext context) {
            _context = context;
        }

        public IActionResult OnGet () {
            ViewData["BookId"] = new SelectList (_context.Book, "Id", "Title");
            ViewData["PatronId"] = new SelectList (_context.Patron, "Id", "Name");
            return Page ();
        }

        [BindProperty]
        public Reservation Reservation { get; set; }

        public async Task<IActionResult> OnPostAsync () {
            if (!ModelState.IsValid) {
                ViewData["BookId"] = new SelectList (_context.Book, "Id", "Title");
                ViewData["PatronId"] = new SelectList (_context.Patron, "Id", "Name");
                return Page ();
            }

            _context.Reservation.Add (Reservation);
            await _context.SaveChangesAsync ();

            return RedirectToPage ("./Index");
        }
    }
}