using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _14_SecondWebApp.Pages
{
    public class SubtractionModel : PageModel
    {
		public double? Result { get; set; }
		public string Calculation { get; set; }



		public void OnGet()
		{
		}

		[HttpPost]
		public IActionResult OnPostCalculateAndRedirect(double minuend, double subtrahend)
		{
			double summe = minuend - subtrahend;
			return RedirectToPage("Result", new { result = summe, calculation = $"{minuend} - {subtrahend} = ", source = "Subtraction" });        //Wir leiten auf die Seite Result weiter            
																																				  //anonymes Object        
		}
	}
}
