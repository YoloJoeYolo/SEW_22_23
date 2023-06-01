using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test301primeFactorization.Pages
{
    public class PrimefactorsModel : PageModel
    {
        public string Result { get; set; } = "Sry but no Primefactor got calculated";
        public int Number { get; set; }

        public void OnGet(int number)
        {
            Number = number;
            Result = CalculatePrimefactors(number);
        }

        private string CalculatePrimefactors(int number)
        {
            if (number < 2) {
                return number.ToString();
            }

            string solution = "";
			while (number % 2 == 0) {
                solution += " * 2";
                number /= 2;
            }
            int factor = 3;
            while (factor <= number) { 
                if(number % factor == 0) {
                    solution += " * " +factor.ToString();
                    number /= factor;
                }
                else
                {
                    if(factor < number)
                    {
                        factor++;
                    }
                    else
                    {
                        return solution.Substring(2);
                    }
                }
            }
			return solution.Substring(2);
		}
    }
}
