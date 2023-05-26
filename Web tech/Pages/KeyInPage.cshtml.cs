using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace Web_tech.Pages
{
    [Authorize(Roles = "Admin")]
    public class KeyInPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
