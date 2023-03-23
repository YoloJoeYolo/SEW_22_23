using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hue04.Pages
{
    public class RandomValueModel : PageModel
    {
		public string Result { get; set; } = "Try generating a random number by clicking on button.";
		public int Min { get; set; }
		public int Max { get; set; }
		

		Random random = new Random();

		public void OnGet(int? min, int? max)
		{
			SetValues(min, max);
			GenerateRandomValue();
		}

		[HttpPost]
		public void OnPostGenerateRandomValue(int? min, int? max)
		{
			SetValues(min, max);
			GenerateRandomValue();
		}

		private void GenerateRandomValue()
		{
			this.Result = random.Next(Min, Max).ToString();
		}

		private void SetValues(int? min, int? max)
		{
			if (min.HasValue)
			{
				Min = min.Value;
			}
			else
			{
				Min = 0;
			}
			if (max.HasValue)
			{
				Max = max.Value;
			}
			else
			{
				Max = 0;
			}
		}
	}
}
