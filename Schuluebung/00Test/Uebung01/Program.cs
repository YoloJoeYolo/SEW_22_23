DateTime date = DateTime.Now;
MoonPhases phase = MoonPhases.Waxingcrescent;

do
{
    Moon.GetMoonPhase(date, ref phase);
    if (phase != MoonPhases.Newmoon)
    {
        date.AddDays(1);
    }
} while (phase != MoonPhases.Newmoon);

Console.WriteLine("The next newmoon is no the: " + date.ToLongDateString());

public enum MoonPhases
{
    /// <summary>
    /// Newmoon phase.
    /// </summary>
    Newmoon = 0,
    /// <summary>
    /// Waxing crescent moon phase.
    /// </summary>
    Waxingcrescent = 1,
    /// <summary>
    /// First quarter phase.
    /// </summary>
    Firstquarter = 2,
    /// <summary>
    /// Waxing gibbous moon phase.
    /// </summary>
    Waxinggibbous = 3,
    /// <summary>
    /// Fullmoon phase.
    /// </summary>
    Fullmoon = 4,
    /// <summary>
    /// Waning gibbous moon phase.
    /// </summary>
    Waninggibbous = 5,
    /// <summary>
    /// Last quarter phase.
    /// </summary>
    Lastquarter = 6,
    /// <summary>
    /// Waning crescent moon phase.
    /// </summary>
    Waningcrescent = 7
}
public class Moon
{
    /// <summary>
    /// The moonphase of the given date.
    /// </summary>
    public MoonPhases Phase;

    /// <summary>
    /// Initializes a new instance of the <see cref="Moon"/> class.
    /// </summary>
    /// <param name="year">The year.</param>
    /// <param name="day">The day.</param>
    /// <param name="hour">The hour.</param>
    public static void GetMoonPhase(DateTime date, ref MoonPhases phase)
    {
        int day = date.Day;
        int month = date.Month;
        int year = date.Year;

        int yy = year - (Int32)((12 - month) / 10);
        int mm = month + 9;
        if (mm >= 12) { mm = mm - 12; }
        int k1 = (Int32)(365.25 * (yy + 4712));
        int k2 = (Int32)(30.6 * mm + .5);
        int k3 = (Int32)((Int32)((yy / 100) + 49) * .75) - 38;
        int j = k1 + k2 + day + 59;
        if (j > 2299160) { j = j - k3; }
        double v = (j - 2451550.1) / 29.530588853;
        v = v - (Int32)(v);
        if (v < 0) { v = v + 1; }
        double ag = v * 29.53;
        if ((ag > 27.6849270496875) || (ag <= 1.8456618033125))
        {
            phase = MoonPhases.Newmoon;
        }
        else if ((ag > 1.8456618033125) && (ag <= 5.5369854099375))
        {
            phase = MoonPhases.Waxingcrescent;
        }
        else if ((ag > 5.5369854099375) && (ag <= 9.2283090165625))
        {
            phase = MoonPhases.Firstquarter;
        }
        else if ((ag > 9.2283090165625) && (ag <= 12.9196326231875))
        {
            phase = MoonPhases.Waxinggibbous;
        }
        else if ((ag > 12.9196326231875) && (ag <= 16.6109562298125))
        {
            phase = MoonPhases.Fullmoon;
        }
        else if ((ag > 16.6109562298125) && (ag <= 20.3022798364375))
        {
            phase = MoonPhases.Waninggibbous;
        }
        else if ((ag > 20.3022798364375) && (ag <= 23.9936034430625))
        {
            phase = MoonPhases.Lastquarter;
        }
        else if ((ag > 23.9936034430625) && (ag <= 27.6849270496875))
        {
            phase = MoonPhases.Waningcrescent;
        }
        else
        {
            phase = MoonPhases.Fullmoon;
        }
    }
}
