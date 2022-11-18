using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Events
{
    internal class Person
    {
        public string Name { get; set; }
        public void enter(Bar b)
        {
            b.SpendRoundEvent += ReceiveDrink;
        }
        public void enter(ExtendedBar b)        {
            b.SpendRoundEvent += ReceiveDrinkExtended;
        }

        public void leave(Bar b)
        {
            b.SpendRoundEvent -= ReceiveDrink;
        }

        public void leave(ExtendedBar b)
        {
            b.SpendRoundEvent -= ReceiveDrinkExtended;
        }

        private void ReceiveDrink(object? sender, EventArgs e)
        {
            Console.WriteLine(this.Name + " is happy about the drink!");
        }

        private void ReceiveDrinkExtended(object? sender, DrinkEventArgs e)
        {
            if(e.Drink == DrinkType.Alcoholic)
            {
                Console.WriteLine(this.Name + " doesn't like alcoholic drinks.");
            }
            else if (e.Drink == DrinkType.NonAlcoholic)
            {
                Console.WriteLine(this.Name + " is happy about the drink");
            }
        }

    }
}
