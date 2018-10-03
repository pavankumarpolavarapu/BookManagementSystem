using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookManagement.Models;

namespace BookManagement.Pages.Reservations
{
    public class IndexModel : PageModel
    {
        private readonly BookManagement.Models.AppDbContext _context;

        public IndexModel(BookManagement.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Reservation> Reservation { get;set; }

        public async Task OnGetAsync()
        {
            Reservation = await _context.Reservation
                .Include(r => r.Book)
                .Include(r => r.Patron).ToListAsync();
        }
    }
}
