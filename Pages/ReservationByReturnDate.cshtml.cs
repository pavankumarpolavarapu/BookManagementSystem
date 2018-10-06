using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Pages {
    public class ReservationByReturnDateModel : PageModel {
        private readonly BookManagement.Models.AppDbContext _context;
        public ICollection<Reservation> Reservations { get; set; }
        public DateTime begin { get; set; }
        public DateTime end { get; set; }
        public ReservationByReturnDateModel (BookManagement.Models.AppDbContext context) {
            _context = context;
        }
        public void OnGet (string from, string to) {
            begin = DateTime.ParseExact (from,
                "yyyyMMdd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None);

            end = DateTime.ParseExact (to,
                "yyyyMMdd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None);

            Reservations = _context.Reservation
                .Include (b => b.Book)
                .Where (r => r.ReturnDate > begin)
                .Where (r => r.ReturnDate < end)
                .ToList ();
        }
    }
}