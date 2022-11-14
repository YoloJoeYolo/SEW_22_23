namespace Hue01_Csharp
{
    internal class Measurment
    {
        public DateTime Time { get; set; }
        public double Value { get; set; }

        public Measurment(DateTime time, double value)
        {
            this.Time = time;
            this.Value = value;
        }
    }
}
