using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _13_FirstWebApp.Pages
{
    public class TimeModel : PageModel
    {
        public string Time { get; set; }
        public void OnGet()
        {
            this.Time = DateTime.Now.ToShortTimeString();
        }
    }
}
