using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hue04.Pages
{
    public class TimeTillEndOfSchoolModel : PageModel
    {
        public String Days { get; set; }
        public String Hours { get; set; }
        public String Minutes { get; set; }
        public String Seconds { get; set; }

        public void OnGet()
        {
            TimeSpan timeTillEndOfSchool = new DateTime(2023, 06, 30, 9, 20, 0) - DateTime.Now;
            Days = Math.Round(timeTillEndOfSchool.TotalDays, 2).ToString();
            Hours = Math.Round(timeTillEndOfSchool.TotalHours, 2).ToString();
            Minutes = Math.Round(timeTillEndOfSchool.TotalMinutes, 2).ToString();
            Seconds = Math.Round(timeTillEndOfSchool.TotalSeconds, 2).ToString();
        }
    }
}
