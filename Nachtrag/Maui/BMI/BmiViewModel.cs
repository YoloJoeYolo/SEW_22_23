using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class BmiViewModel : INotifyPropertyChanged
    {
        private double? weight;
        private double? height;
        private string bmi;

        public double? Weight { get { return weight; } set { weight = value; CalculateBmi(); OnPropertyChanged(nameof(Weight)); } }
        public double? Height { get { return height; } set { height = value; CalculateBmi(); OnPropertyChanged(nameof(Height)); } }
        public string Bmi { get { return bmi; } set { bmi = value; OnPropertyChanged(nameof(Bmi)); } }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void CalculateBmi()
        {
            if(weight.HasValue && height.HasValue)
            {
                double b = Weight.Value / (Height.Value * Height.Value);
                Bmi = $"Dein BMI: {b:F2}";
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
