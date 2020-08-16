using System;

public class Clock
{
    int  internalHours;
    int internalMinutes;
    public Clock(int hours, int minutes)
    {
        if (minutes > 59) {
            int round = 100/60;
            internalHours  += Math.Round(round, 0);
            internalMinutes += (minutes % 60);
        }
         if(hours > 23){
             internalHours = hours % 24; 
         }else {
             internalHours = hours;
             internalMinutes = minutes;
         }
         

    }

    public int Hours
    {
        get
        {
            return internalHours;
        }
    }

    public int Minutes
    {
        get
        {
            return internalMinutes;
        }
    }

    public Clock Add(int minutesToAdd)
    {
       return null;
    }

    public Clock Subtract(int minutesToSubtract)
    {
      return null;
    }

    public override string ToString()
    {
        string hours = $"{internalHours}"; 
        string minutes = $"{internalMinutes}";


        if(internalHours < 10) {
            hours = $"0" + $"{internalHours}";
        };

        if (internalMinutes < 10) {
            minutes = $"0" + $"{internalMinutes}";
        }

        return $"{hours}" + ":" + $"{minutes}";
    }

 
}

