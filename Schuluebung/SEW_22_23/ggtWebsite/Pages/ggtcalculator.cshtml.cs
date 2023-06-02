using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ggtWebsite.Pages
{
    public class ggtcalculatorModel : PageModel
    {
        public string Result { get; set; } = "Sry but no GGT got calculated";
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public void OnGet(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
            Result = CalculateGGT(number1, number2);
        }

        private string CalculateGGT(int number1, int number2)
        {
            int functionReturnValue = 0;
            if (number1 < 0)
            {
                number1 = number1 * (-1);
            }
            while (number2 > 0)
            {
                functionReturnValue = number1 % number2;
                number1 = number2;
                number2 = functionReturnValue;
            }
            return number1.ToString();
        }
    }
}
