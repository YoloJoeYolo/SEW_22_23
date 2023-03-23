using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hue04.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public String Image { set; get; }
		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
			if (DateTime.Now.Minute % 2 == 0)
			{
				Image = "img/mountain.jpg";

            }
			else
			{
				Image = "img/forest.jpg";
            }
		}
	}
}