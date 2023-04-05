using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HUE05.Pages
{
    public class HikingTrailCalculatorModel : PageModel
    {
        public int Distance { get; set; }
        public int AltitudeGain { get; set; }
        public int AltitudeLoss { get; set; }

        public string Result { get; set; }

        public void OnGet(int? distance, int? altitudeGain, int? altitudeLoss, string? result)
        {
            SetValues(distance, altitudeGain, altitudeLoss, result);
        }


        public void OnPostCalculatHikingTime(int? distance, int? altitudeGain, int? altitudeLoss)
        {
            SetValues(distance, altitudeGain, altitudeLoss);

            float horizontalHikingTime = Distance/4000;

            float verticalHikingTime = AltitudeGain/300;
            verticalHikingTime += AltitudeLoss / 500;

            if(horizontalHikingTime > verticalHikingTime)
            {
                horizontalHikingTime += verticalHikingTime / 2;
            }
            else
            {
                horizontalHikingTime = horizontalHikingTime / 2 + verticalHikingTime;
            }

            Result = ((int) horizontalHikingTime).ToString() + "h";
            float minutes = horizontalHikingTime - (int)horizontalHikingTime;
            if(minutes >= 0.75)
            {
                Result = ((int)horizontalHikingTime + 1).ToString() + "h";
            }
            else if( minutes >= 0.50)
            {
                Result = ((int)horizontalHikingTime).ToString() + "h 45min";

            }
            else if (minutes >= 0.25)
            {
                Result = ((int)horizontalHikingTime).ToString() + "h 30min";

            }
            else
            {
                Result = ((int)horizontalHikingTime).ToString() + "h 15min";
            }
        }

        private void SetValues(int? distance, int? altitudeGain, int? altitudeLoss, string? result = null)
        {
            if (distance.HasValue)
            {
                Distance = distance.Value;
            }
            else
            {
                Distance = 0;
            }
            if (altitudeGain.HasValue)
            {
                AltitudeGain = altitudeGain.Value;
            }
            else
            {
                AltitudeGain = 0;
            }
            if (altitudeLoss.HasValue)
            {
                AltitudeLoss = altitudeLoss.Value;
            }
            else
            {
                AltitudeLoss = 0;
            }
            if (result != null)
            {
                Result = result;
            }
            else
            {
                Result = "null";
            }
        }
    }
}
