namespace GitlabHoursLib
{
    public class WeekParser : Parser
    {
        protected override string LogUnit => GitlabHoursLib.LogUnit.Week;
        protected override int MinutesInUnit => Minutes.InAWeek;
    }
}
