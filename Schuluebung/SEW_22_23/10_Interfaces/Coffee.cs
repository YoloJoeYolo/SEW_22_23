using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces
{
    internal class Coffee : IHotDrink, IHasCaffeine
    {
        public Coffee(string type)
        {
            this.Type = type;
            this.Degree = 90;
        }

        public string Type { get; }
        public int Degree { get; set; }

        public float Caffeine {
            get
            {
                return 40;
            }
                
        }

        public void cool()
        {
            this.Degree -= 2;
        }
    }
}
