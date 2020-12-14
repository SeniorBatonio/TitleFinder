using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TitleFinder.Models;

namespace TitleFinder.Controllers
{
    public class FinderController : Controller
    {
        [HttpPost]
        public async Task<ActionResult<string>> FindAsync(string url)
        {
            var client = new WebClient();
            string source = await client.DownloadStringTaskAsync(url);
            string title = Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>",
                RegexOptions.IgnoreCase).Groups["Title"].Value;
            return Ok(new UrlData { Url = url, Title = title });
        }
    }
}
