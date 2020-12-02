namespace GitlabHoursLib
{
    public class HourParser : Parser
    {
        protected override string LogUnit => GitlabHoursLib.LogUnit.Hour;
        protected override int MinutesInUnit => Minutes.InAnHour;
    }
}
