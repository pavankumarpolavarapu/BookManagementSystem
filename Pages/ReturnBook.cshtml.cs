using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Pages {
    public class ReturnBookModel : PageModel {
        private readonly AppDbContext _context;
        public ReturnBookModel (AppDbContext context) {
            _context = context;
        }

        [BindProperty]
        public ReturnBookForm ReturnBookForm { get; set; }
        public Reservation Reservation { get; set; }

        public IActionResult OnGet (int? id) {
            if (id == null) {
                return NotFound ();
            }

            Reservation = _context.Reservation
                .Include (b => b.Book)
                .FirstOrDefault (m => m.Id == id);

        if (Reservation == null) {
            return NotFound ();
        }

        ReturnBookForm = new ReturnBookForm ();
        ReturnBookForm.ReservationId = Reservation.Id;
        return Page ();
    }

    public IActionResult OnPost () {
        Reservation = _context.Reservation.Find (ReturnBookForm.ReservationId);

        if (!ModelState.IsValid) {
            return Page ();
        }

        // UPDATE THE AGENT RETRIEVED FROM THE DATABASE
        Reservation.ActualReturnDate = ReturnBookForm.ActualReturnDate;
        // TELL THE DATABASE TO SAVE WHATEVER CHANGES WE MADE
        _context.SaveChanges ();
        return RedirectToPage ("/ReturnBook", new { id = Reservation.Id });
    }
}
}