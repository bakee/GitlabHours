namespace GitlabHours
{
    public class MonthParser : Parser
    {
        protected override string LogUnit => GitlabHours.LogUnit.Month;
        protected override int MinutesInUnit => Minutes.InAMonth;
    }
}
