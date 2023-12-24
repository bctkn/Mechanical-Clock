namespace ClockLib
{
    public interface IClock
    {
        public DateTime Time { get { return DateTime.Now; } }
    }

    public class Clock : IClock
    {
       
    }
}