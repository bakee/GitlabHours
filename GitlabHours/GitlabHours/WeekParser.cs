namespace GitlabHours
{
    public class WeekParser : Parser
    {
        protected override string LogUnit => GitlabHours.LogUnit.Week;
        protected override int MinutesInUnit => Minutes.InAWeek;
    }
}
