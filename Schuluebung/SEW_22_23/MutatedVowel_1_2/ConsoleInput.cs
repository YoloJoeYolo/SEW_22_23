using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutatedVowel_1_2
{
    internal class ConsoleInput
    {
        public event EventHandler<MutatedVowelEventArgs> MutatedVowelInput;

        public string ReadInput(string description)
        {
            Console.Write(description);
            string result = Console.ReadLine();
            if (result.ToLower().Contains("ä"))
            {
                if (MutatedVowelInput != null)
                {
                    MutatedVowelInput(this, new MutatedVowelEventArgs('ä'));
                }
            }
            if (result.ToLower().Contains("ö"))
            {
                if (MutatedVowelInput != null)
                {
                    MutatedVowelInput(this, new MutatedVowelEventArgs('ö'));
                }

            }
            if (result.Contains("ü"))
            {
                if (MutatedVowelInput != null)
                {
                    MutatedVowelInput(this, new MutatedVowelEventArgs('ü'));
                }
            }
            return result;
        }
    }

}
