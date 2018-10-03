using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookManagement.Models;

namespace BookManagement.Pages.Patrons
{
    public class EditModel : PageModel
    {
        private readonly BookManagement.Models.AppDbContext _context;

        public EditModel(BookManagement.Models.AppDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Patron).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatronExists(Patron.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PatronExists(int id)
        {
            return _context.Patron.Any(e => e.Id == id);
        }
    }
}
