using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces
{
    internal class HotSpicedWine : IHotDrink
    {
        public HotSpicedWine()
        {
            Degree = 80;
        }

        public int Degree { get; set; }

        public void cool()
        {
            this.Degree--;
        }
    }
}
