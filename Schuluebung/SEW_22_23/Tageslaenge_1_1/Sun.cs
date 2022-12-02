using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tageslaenge_1_1
{
    internal class Sun
    {
        private double latitude;
        private double longitude;
        public Sun(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public void SunriseAndSunset(int day, int month, int year, out DateTime sunrise, out DateTime sunset)
        {
            double pi = Math.PI;
            double dr = pi / 180;
            double rd = 1 / dr;
            double lat = this.latitude;
            double @long = this.longitude;
            double h = 0;    // timezone UTC
            DateTime now = DateTime.Now;
            int m = month;
            int d = day;
            lat = dr * lat;
            int n = (Int32)(275 * m / 9) - 2 * (Int32)((m + 9) / 12) + d - 30;
            double l0 = 4.8771 + .0172 * (n + .5 - @long / 360);
            double c = .03342 * Math.Sin(l0 + 1.345);
            double c2 = rd * (Math.Atan(Math.Tan(l0 + c)) - Math.Atan(.9175 * Math.Tan(l0 + c)) - c);
            double sd = .3978 * Math.Sin(l0 + c);
            double cd = Math.Sqrt(1 - sd * sd);
            double sc = (sd * Math.Sin(lat) + .0145) / (Math.Cos(lat) * cd);

            if (Math.Abs(sc) <= 1)
            {
                // calculate sunrise 
                double c3 = rd * Math.Atan(sc / Math.Sqrt(1 - sc * sc));
                double r1 = 6 - h - (@long + c2 + c3) / 15;
                int hr = (Int32)(r1);
                int mr = (Int32)((r1 - hr) * 60);
                sunrise = new DateTime(year, month, day, hr, mr, 0);
                // calculate sunset
                double s1 = 18 - h - (@long + c2 - c3) / 15;
                int hs = (Int32)(s1);
                int ms = (Int32)((s1 - hs) * 60);
                sunset = new DateTime(year, month, day, hs, ms, 0);
            }
            else
            {
                if (sc > 1)
                {
                    // sun is up all day ...
                    // Set Sunset to be in the future ...
                    sunset = new DateTime(now.Year + 1, now.Month, now.Day, now.Hour, now.Minute, now.Second);
                    // Set Sunrise to be in the past ...
                    sunrise = new DateTime(now.Year - 1, now.Month, now.Day, now.Hour, now.Minute - 1, now.Second);
                }
                else
                {
                    // sun is down all day ...
                    // Set Sunrise and Sunset to be in the future ...
                    sunrise = new DateTime(now.Year + 1, now.Month, now.Day, now.Hour, now.Minute, now.Second);
                    sunset = new DateTime(now.Year + 1, now.Month, now.Day, now.Hour, now.Minute, now.Second);
                }
            }
        }
    }

}
