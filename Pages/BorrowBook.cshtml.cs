using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookManagement.Pages {
    public class BorrowBookModel : PageModel {

        private readonly AppDbContext _context;
        public BorrowBookModel (AppDbContext context) {
            _context = context;
        }

        [BindProperty]
        public BorrowBookForm BorrowBookForm { get; set; }
        public void OnGet () {
            PopulateSelectLists ();
        }

        public IActionResult OnPost () {
            if (!ModelState.IsValid) {
                PopulateSelectLists ();
                return Page ();
            }

            var reservation = new Reservation ();
            reservation.BookId = BorrowBookForm.BookId;
            reservation.PatronId = BorrowBookForm.PatronId;
            reservation.BorrowDate = DateTime.Now;
            reservation.ReturnDate = DateTime.Now.AddDays (15);
            _context.Reservation.Add (reservation);
            _context.SaveChanges ();
            return RedirectToPage ("/Reservations/details", new { Id = reservation.Id });
        }

        private void PopulateSelectLists () {
            // GET ACTIVE AGENTS
            var patrons = _context.Patron
                .ToList ();

            // NOTE WE SET THE ViewData property with the same name as the 
            // property name in our model that will hold the selected value
            ViewData["PatronId"] = new SelectList (patrons, "Id", "Name");
            var books = _context.Book
                .ToList ();

            // NOTE WE SET THE ViewData property with the same name as the 
            // property name in our model that will hold the selected value
            ViewData["BookId"] = new SelectList (books, "Id", "Title");
        }
    }
}