using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITHS_DB_Lab4_ClassLib.DataAccess;
using ITHS_DB_Lab4_DbModel.Models;

namespace ITHS_DB_Lab4_Web.Pages.Pepole
{
    public class IndexModel : PageModel
    {
        private readonly ExersiceContext _context;

        public IndexModel(ExersiceContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
