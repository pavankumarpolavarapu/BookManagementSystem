using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Pages {
    public class PatronReservationsModel : PageModel {
        private readonly BookManagement.Models.AppDbContext _context;
        public Patron Patron { get; set; }
        public PatronReservationsModel (BookManagement.Models.AppDbContext context) {
            _context = context;
        }
        public IActionResult OnGet (int? id) {
            Patron = _context.Patron
                .Include (b => b.Reservations)
                .ThenInclude (c => c.Book)
                .FirstOrDefault (p => p.Id == id);
            if (Patron == null) {
                return NotFound ();
            }
            return Page ();

        }
    }
}