using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _14_SecondWebApp.Pages
{
    public class PersonModel : PageModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IList<string> Mails { get; set; }

        public string Image { get; set; }

        public void OnGet([FromRoute]int id, string? img)
        {
            if (id == 5)
            {
                FirstName = "Tobias";
                LastName = "Zarzer";
                this.Mails = new List<string>();
                this.Mails.Add("tobias.zarzer@josephinum.at");
                this.Mails.Add("tobias.zarzertz@gmail.com");
                this.Image = "img/kuh.jpg";
            }
            else
            {
                FirstName = "Stefan";
                LastName = "Schwödiauer";
                this.Mails = new List<string>();
                this.Mails.Add("stefan.schwoediauer@josephinum.at");
                this.Mails.Add("stefan@schwoediauer.at");
                this.Image = "img/pute.jpg";
            }

            if(img != null)
            {
                this.Image = img;
            }
        }
    }
}
