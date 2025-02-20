public class Swimming : Activity
{
    private int _laps;
    private const double METERS_TO_MILES = 0.00062137119;
    private const int LAP_LENGTH_METERS = 50;

    public Swimming(DateTime date, int minutes, int laps) 
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * LAP_LENGTH_METERS * METERS_TO_MILES;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
