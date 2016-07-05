using Xunit;
namespace ClockAngle
{
  public class ClockAngleTest
  {
    [Fact]
    public void hour_angle_true()
    {
      Clock testClock = new Clock(6,45);
      Assert.Equal(202.5, testClock.GetAngle());
    }
  }
}
