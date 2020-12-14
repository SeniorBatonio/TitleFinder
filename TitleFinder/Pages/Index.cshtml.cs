using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TitleFinder.Models;

namespace TitleFinder.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Urls { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var urls = Urls.Split(Environment.NewLine);
            return RedirectToPage("./Finder", new { urls });
        }
    }
}
