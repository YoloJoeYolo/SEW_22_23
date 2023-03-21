using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;

namespace _14_SecondWebApp.Pages
{
    public class CollatzModel : PageModel
    {
		public List<int> Collatz { get; set; }
		public void OnGet()
		{
		}

		//[HttpPost]
		//public IActionResult OnPostCalculateCollatz(int startNum)
		//{
		//	int oldNum = startNum;
		//	for (int i = 0; old == 1; i++)
		//	{

		//	}

		//}
	}
}
