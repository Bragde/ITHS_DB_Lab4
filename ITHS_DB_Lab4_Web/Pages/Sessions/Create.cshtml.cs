using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ITHS_DB_Lab4_ClassLib.DataAccess;
using ITHS_DB_Lab4_DbModel.Models;

namespace ITHS_DB_Lab4_Web.Pages.Sessions
{
    public class CreateModel : PageModel
    {
        private readonly ITHS_DB_Lab4_ClassLib.DataAccess.ExersiceContext _context;

        public CreateModel(ITHS_DB_Lab4_ClassLib.DataAccess.ExersiceContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FirstName");
            return Page();
        }

        [BindProperty]
        public Session Session { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Session.Add(Session);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
