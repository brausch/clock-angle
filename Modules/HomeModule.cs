using Nancy;
using System.Collections.Generic;
using ClockAngle;

namespace ClockAngle
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/Angle"] = _ => {
        Clock newClock = new Clock(
        Request.Query["hour"],Request.Query["minute"]);
        return View["angle.cshtml", newClock];
      };
    }
  }
}
