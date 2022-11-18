
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Events
{
    internal class ExtendedBar
    {
        public event EventHandler<DrinkEventArgs> SpendRoundEvent;
        public string Name { get; set; }

        public void SpendAlcoholicDrink()
        {
            if(this.SpendRoundEvent != null)
            {
                this.SpendRoundEvent(this, new DrinkEventArgs(DrinkType.Alcoholic));
            }
        }

        public void SpendNonAlcoholicDrink()
        {
            if (this.SpendRoundEvent != null)
            {
                this.SpendRoundEvent(this, new DrinkEventArgs(DrinkType.NonAlcoholic));
            }
        }
    }
}
