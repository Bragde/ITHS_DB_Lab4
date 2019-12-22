using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITHS_DB_Lab4_ClassLib.DataAccess;
using ITHS_DB_Lab4_DbModel.Models;

namespace ITHS_DB_Lab4_Web.Pages.Sessions
{
    public class DeleteModel : PageModel
    {
        private readonly ITHS_DB_Lab4_ClassLib.DataAccess.ExersiceContext _context;

        public DeleteModel(ITHS_DB_Lab4_ClassLib.DataAccess.ExersiceContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Session = await _context.Session.FindAsync(id);

            if (Session != null)
            {
                _context.Session.Remove(Session);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
