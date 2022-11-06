namespace Hue01_Csharp
{
    internal class Measurment
    {
        DateTime time;
        double value;

        public Measurment(DateTime time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public DateTime Time
        {
            get{return time;}
            set{time = value;}
        }

        public Double Value
        {
            get{return value;}
            set{this.value = value;}
        }
    }
}
