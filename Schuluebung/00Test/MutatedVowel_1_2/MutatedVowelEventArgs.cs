using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutatedVowel_1_2
{
    internal class MutatedVowelEventArgs : EventArgs
    {
        public char MutatedVowel { get; }
        public MutatedVowelEventArgs(char vowel) : base()
        {
            this.MutatedVowel = vowel;
        }
    }

}
