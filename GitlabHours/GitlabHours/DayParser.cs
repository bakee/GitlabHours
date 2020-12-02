namespace GitlabHours
{
    public class DayParser : Parser
    {
        protected override string LogUnit => GitlabHours.LogUnit.Day;
        protected override int MinutesInUnit => Minutes.InADay;
    }
}
