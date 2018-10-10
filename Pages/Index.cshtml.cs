using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Pages {
    public class IndexModel : PageModel {
        private readonly AppDbContext _context;
        public IndexModel (AppDbContext context) {
            _context = context;
        }
        public int NoOfBooks;
        public int NoOfProgrammingBooks;
        public int NoOfPatrons;
        public int NoOfMalePatrons;
        public int NoOfFemalePatrons;

        public void OnGet () {
            NoOfBooks = _context.Book
                .Count ();
            NoOfProgrammingBooks = _context.Book
                .Where (a => a.Genre == "Programming")
                .Count ();
            NoOfPatrons = _context.Patron
                .Count ();
            NoOfMalePatrons = _context.Patron
                .Where (a => a.Gender == "Male")
                .Count ();
            NoOfFemalePatrons = _context.Patron
                .Where (a => a.Gender == "Female")
                .Count ();
        }
    }
}