namespace GitlabHoursLib
{
    public class DayParser : Parser
    {
        protected override string LogUnit => GitlabHoursLib.LogUnit.Day;
        protected override int MinutesInUnit => Minutes.InADay;
    }
}
