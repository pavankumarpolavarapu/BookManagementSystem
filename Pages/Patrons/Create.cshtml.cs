using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookManagement.Models;

namespace BookManagement.Pages.Patrons
{
    public class CreateModel : PageModel
    {
        private readonly BookManagement.Models.AppDbContext _context;

        public CreateModel(BookManagement.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Patron Patron { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Patron.Add(Patron);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
