using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_IComparable
{
    internal class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public DateTime Birthday { get; set; }
        public enum CompareType { FirstName, LastName, Birthday}
        public static CompareType Compare { get; set; } // --> in CompareTo abfragen um verschiedene Sachen zu vergleichen oder mit einen Comparer

        public int CompareTo(Student? other)    // IComparable notwendig, wenn ich sortieren möchte
        {
            // return: -1 wenn  kleiner
            // return: 0 wenn gleich
            // return: 1 wenn größer

            // Variante 1: sehr umständlich
            //if(this.Birthday == other.Birthday)
            //{
            //    return 0;
            //}
            //if (this.Birthday < other.Birthday)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 1;
            //}

            //return this.Birthday.CompareTo(other.Birthday); // nachdem auch DateTime IComparable implementiert
            // können wir dies einfach aufrufen
            // return -1 * this.Birthday.CompareTo(other.Birthday);
            //return other.Birthday.CompareTo(this.Birthday);

            return this.FirstName.CompareTo(other.FirstName);
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " - " + Birthday.ToShortDateString();
        }
    }
}
