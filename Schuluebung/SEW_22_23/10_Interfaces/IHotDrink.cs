using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces
{
    internal interface IHotDrink
    {
        public int Degree { get; set; }
        public void cool();
    }
}
