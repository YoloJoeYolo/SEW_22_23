using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _14_SecondWebApp.Pages
{
    public class CollatzResultModel : PageModel
    {
        public string Result { get; set; }
        public string Source { get; set; }
        public void OnGet(string result, string source)
        {
            Result = result;
            Source = source;
        }
    }
}
