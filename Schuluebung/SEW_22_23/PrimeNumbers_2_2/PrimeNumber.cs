using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers_2_2
{
    internal class PrimeNumber
    {
        public Action<int> PrimeNumberFound;
        // event anbieten, wann Primenumber gefunden mit Func und Action
        public async Task GeneratePrimeNumbersAsync(int start, int end)
        {
            await Task.Run(() =>
            {
                for (int i = start; i < end; i++)
                {
                    if (IsPrime(i))
                    {
                        if (PrimeNumberFound != null)
                        {
                            PrimeNumberFound(i);
                        }
                    }
                }
            });
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
