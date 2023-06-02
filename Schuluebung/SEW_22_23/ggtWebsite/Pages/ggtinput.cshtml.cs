using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ggtWebsite.Pages
{
    public class ggtinputModel : PageModel
    {
        public void OnGet()
        {
        }

		[HttpPost]
		public IActionResult OnPostGGT(int number1, int number2)
		{
			return RedirectToPage("ggtcalculator", new { number1 = number1, number2 = number2 });
		}
	}
}
