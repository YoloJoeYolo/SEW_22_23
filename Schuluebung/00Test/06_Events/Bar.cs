using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Events
{
    internal class Bar
    {
        public event EventHandler<EventArgs> SpendRoundEvent;
        public string Name { get; set; }
        public void SpendRound()
        {
            if(this.SpendRoundEvent != null) // ob Methoden registriert sind
            {
                this.SpendRoundEvent(this, EventArgs.Empty);
            }
        }
    }
}
