using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MiniProject319.Views.Menu
{
    public class DetailDokter : PageModel
    {
        private readonly ILogger<DetailDokter> _logger;

        public DetailDokter(ILogger<DetailDokter> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}