using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung02
{
    internal class Person
    {
        public event EventHandler<EventArgs> LastNameChanged;

        String firstName;
        String lastName;

        public Person(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName= lastName;
        }

        public String LastName
        {
            get { return this.lastName; }
            set
            {
                lastName = value;
                if (this.LastNameChanged != null)
                {
                    this.LastNameChanged(this, EventArgs.Empty);
                }
            }
        }

        public String FirstName { get { return this.firstName; } }
    }
}
