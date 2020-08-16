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
        
        int finalMinutes = minutes % 60;
        //this is where I am unable to convert the resulting int to a double
        double testConversion = Convert.ToDouble(minutes/60);
        //int excessMinutes = Math.Round(internalMinutes/60, 0), needs to be a double to work. 
        double excessMinutes = Math.Round(testConversion, 0);
        int excessHours = hours % 24; 
        double finalHours = excessHours + excessMinutes;

        internalHours = finalHours; 
        internalMinutes = finalMinutes; 


  
    }

 
}

