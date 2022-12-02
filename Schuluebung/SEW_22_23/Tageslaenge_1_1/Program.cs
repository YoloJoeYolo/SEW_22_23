using Tageslaenge_1_1;

Sun sun = new Sun(48.12754, 15.12402);

DateTime date = DateTime.Now.Subtract(new TimeSpan(24, 0 , 0));
DateTime sunrise;
DateTime sunset;

do
{
    date = date.AddDays(1);
    sun.SunriseAndSunset(date.Day, date.Month, date.Year, out sunrise, out sunset);
} while (sunset.Subtract(sunrise).Hours < 9);

Console.WriteLine("Ab den " +date.ToShortDateString() +" sind die Tage länger als 9 Stunden.");