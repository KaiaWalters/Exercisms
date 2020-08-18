using System;

public class Clock
{
    double internalHours;
    double internalMinutes;
    public Clock(int hours, int minutes)
    {

        convertTime(hours, minutes); 
         

    }

    public double Hours
    {
        get
        {
            return internalHours;
        }
    }

    public double Minutes
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

    public void convertTime(int hours, int minutes) {
        if(hours < 0) {
         hours = hours % 24;
         hours = 23; 
        }
        int finalMinutes = minutes % 60;
     
        double testConversion = Convert.ToDouble(minutes/60);
       
        double excessMinutes = Math.Round(testConversion, 0);
        double excessHours = hours + excessMinutes;
        double finalHours = excessHours % 24;

        internalHours = finalHours;
        internalMinutes = finalMinutes; 


  
    }

 
}

