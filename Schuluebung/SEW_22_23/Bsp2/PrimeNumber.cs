using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp2
{
    public class PrimeNumber
    {
        public Action<int> PrimeFactorFound;

        public async Task GeneratePrimeFactorsAsync(int number)
        {
            for (int div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    if (PrimeFactorFound != null)
                    {
                        PrimeFactorFound(div);
                    }

                    number = number / div;
                }
            }
        }
    }


}
