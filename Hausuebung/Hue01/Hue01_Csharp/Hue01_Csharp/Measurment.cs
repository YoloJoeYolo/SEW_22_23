namespace Hue01_Csharp
{
    internal class Measurment
    {
        public DateTime Time { get;}
        public double Value { get;}

        public Measurment(DateTime time, double value)
        {
            this.Time = time;
            this.Value = value;
        }
    }
}
