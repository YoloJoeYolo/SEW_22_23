using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test301primeFactorization.Pages
{
    public class PrimeinputModel : PageModel
    {
        public void OnGet()
        {
        }

		[HttpPost]
		public IActionResult OnPostCalculatePrimefactors(int number)
		{
			return RedirectToPage("Primefactors", new { number = number});
		}
	}
}
