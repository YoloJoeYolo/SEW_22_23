using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Events
{
    public enum DrinkType
    {
        Alcoholic,
        NonAlcoholic
    }

    internal class DrinkEventArgs : EventArgs
    {
        public DrinkType Drink { get; set; }

        public DrinkEventArgs(DrinkType type)
        {
            this.Drink = type;
        }
    }
}
