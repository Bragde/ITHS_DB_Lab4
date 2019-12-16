using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITHS_DB_Lab4_DbModel;
using ITHS_DB_Lab4_ClassLib.DataAccessService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ITHS_DB_Lab4_Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public DAService_Person DAService;
        public IEnumerable<Person> Pepole { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            DAService_Person DAService)
        {
            _logger = logger;
            this.DAService = DAService;
        }

        public void OnGet()
        {
            Pepole = DAService.GetAll();
        }
    }
}
