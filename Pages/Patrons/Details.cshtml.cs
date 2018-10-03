using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookManagement.Models;

namespace BookManagement.Pages.Patrons
{
    public class DetailsModel : PageModel
    {
        private readonly BookManagement.Models.AppDbContext _context;

        public DetailsModel(BookManagement.Models.AppDbContext context)
        {
            _context = context;
        }

        public Patron Patron { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Patron = await _context.Patron.FirstOrDefaultAsync(m => m.Id == id);

            if (Patron == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
