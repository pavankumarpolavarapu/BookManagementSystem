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
    public class DeleteModel : PageModel
    {
        private readonly BookManagement.Models.AppDbContext _context;

        public DeleteModel(BookManagement.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Patron = await _context.Patron.FindAsync(id);

            if (Patron != null)
            {
                _context.Patron.Remove(Patron);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
