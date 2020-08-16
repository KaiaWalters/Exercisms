using System;

public class Clock
{
    int  internalHours;
    int internalMinutes;
    public Clock(int hours, int minutes)
    {
        int excessMinutes = minutes % 60; 
        internalMinutes = excessMinutes; 
        if(minutes)
        internalHours = minutes


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

    public int convertTime(int internalHours, int internalMinutes) {
        
        int finalMinutes = internalMinutes % 60;
        //this is where I am unable to convert the resulting int to a double
        int testConversion = Convert.ToDouble(internalMinutes/60);
        //int excessMinutes = Math.Round(internalMinutes/60, 0), needs to be a double to work. 
        int excessMinutes = Math.Round(testConversion, 0);
        int excessHours = internalHours % 24; 
        int finalHours = excessHours + excessMinutes;
  
    }

 
}

