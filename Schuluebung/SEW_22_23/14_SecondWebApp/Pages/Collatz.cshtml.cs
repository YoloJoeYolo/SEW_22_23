using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;

namespace _14_SecondWebApp.Pages
{
    public class CollatzModel : PageModel
    {
		public void OnGet()
		{
		}

		[HttpPost]
		public IActionResult OnPostCalculateCollatz(int startNum)
		{
			string collatz = "There are only natural numbers bigger than 0 allowed";

            if (startNum < 1)
			{
                return RedirectToPage("CollatzResult", new { result = collatz, source = "Collatz" });          
            }
			collatz = startNum.ToString();
			while(startNum != 1)
			{
				collatz += ", ";
				if(startNum % 2 == 0)
				{
					startNum = startNum / 2;
				}
				else
				{
					startNum = 3 * startNum + 1;
				}
				collatz += startNum.ToString();
			}
            return RedirectToPage("CollatzResult", new { result = collatz + ", 4, 2, 1, ...", source = "Collatz" });
        }
	}
}
