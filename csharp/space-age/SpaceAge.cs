using System;

public class SpaceAge
{
    public double seconds; 
    public SpaceAge(int seconds)
    {
        this.seconds = seconds; 
    }

    public double OnEarth()
    {
         seconds = this.seconds /31_557_600; 

        return seconds; 
    }

    public double OnMercury()
    {
       seconds = this.OnEarth() / 0.2408467; 
       return seconds; 
    }

    public double OnVenus()
    {
        seconds = this.OnEarth() / 0.61519726; 
       return seconds; 
    }

    public double OnMars()
    {
         seconds = this.OnEarth() / 1.8808158; 
       return seconds; 
    }

    public double OnJupiter()
    {
         seconds = this.OnEarth() / 11.862615; 
       return seconds; 
    }

    public double OnSaturn()
    { seconds = this.OnEarth() / 29.447498; 
       return seconds; 
    }

    public double OnUranus()
    {
         seconds = this.OnEarth() / 84.016846; 
       return seconds; 
    }

    public double OnNeptune()
    {
         seconds = this.OnEarth() / 164.79132; 
       return seconds; 
    }
}