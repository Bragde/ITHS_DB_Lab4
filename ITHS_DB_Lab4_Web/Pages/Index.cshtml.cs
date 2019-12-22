using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITHS_DB_Lab4_ClassLib.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ITHS_DB_Lab4_DbModel.Models;
using Microsoft.EntityFrameworkCore;

namespace ITHS_DB_Lab4_Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ExersiceContext db;
        public IndexModel(ExersiceContext db) => this.db = db;
        public IEnumerable<Person> Pepole { get; private set; }
        public async Task OnGetAsync()
        {
            Pepole = await db.Person.ToListAsync();
        }
    }
}
