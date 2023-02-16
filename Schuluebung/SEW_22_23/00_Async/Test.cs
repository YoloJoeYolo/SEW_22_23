using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Async
{
    internal class Test
    {
        public static async Task SomeMethode(int i)
        {
            await Task.Run(() => {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(j);
                }
            });
            
            // return;
            // hier wird Task-Objekt erstellt
        }

        public static async Task<int> SomeMethode2(int i)
        {
            await Task.Run(() => i = i * 5);
            return i; // Rückgabewert i, wird automatisch in das Task-Objekt verpackt.
        }

        public static async Task<List<int>> SomeMethode3(int i)
        {
            List<int> returnValues = new List<int>();
            await Task.Run(() =>
            {
                for (int j = 0; j < i; j++)
                {
                    returnValues.Add(i);
                }
            });
            return returnValues;
        }

    }
}
