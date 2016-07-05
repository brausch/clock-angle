using System;

namespace ClockAngle
{
  public class Clock
  {
    private float _hour;
    private float _minute;


    public Clock(float hour, float minute)
    {
      _hour = hour;
      _minute = minute;
    }

    public float GetHour()
    {
      return _hour;
    }
    public void SetHour(float newHour)
    {
      _hour = newHour;
    }
    public float GetMinute()
    {
      return _minute;
    }
    public void SetMinute(float newMinute)
    {
      _minute = newMinute;
    }

    public float GetAngle()
    {
    float shorthand = 30 * (_hour + (_minute/60));
    float longhand = 6 * _minute;
    float difference = longhand - shorthand;
    if(Math.Abs(difference) < 180)
    {
      return difference;
    }
    else
    {
      return 360 - difference;
    }

    }
  }
}
