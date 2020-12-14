using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TitleFinder.Models;

namespace TitleFinder.Pages
{
    public class FinderModel : PageModel
    {
        public string[] Urls { get; set; }
        public void OnGet(string[] urls)
        {
            Urls = urls;
        }
    }
}
