using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MiniProject319.Views.Menu
{
    public class CariDokter : PageModel
    {
        private readonly ILogger<CariDokter> _logger;

        public CariDokter(ILogger<CariDokter> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}