namespace ClockLib
{
    public interface IClock
    {
        DateTime Time { get { return DateTime.Now; } }
    }
    public class Clock : IClock
    {

    }
}