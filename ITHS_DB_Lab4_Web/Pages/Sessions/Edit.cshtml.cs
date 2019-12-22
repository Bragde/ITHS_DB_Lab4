using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITHS_DB_Lab4_ClassLib.DataAccess;
using ITHS_DB_Lab4_DbModel.Models;
using Microsoft.VisualBasic.CompilerServices;

namespace ITHS_DB_Lab4_Web.Pages.Sessions
{
    public class EditModel : PageModel
    {
        private readonly ITHS_DB_Lab4_ClassLib.DataAccess.ExersiceContext _context;

        public EditModel(ITHS_DB_Lab4_ClassLib.DataAccess.ExersiceContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Session Session { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Session = await _context.Session
                .Include(s => s.Person).FirstOrDefaultAsync(m => m.Id == id);

            

            if (Session == null)
            {
                return NotFound();
            }
           ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FirstName");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Session).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SessionExists(Session.Id))
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

        private bool SessionExists(int id)
        {
            return _context.Session.Any(e => e.Id == id);
        }
    }
}
