namespace GitlabHoursLib
{
    public class MonthParser : Parser
    {
        protected override string LogUnit => GitlabHoursLib.LogUnit.Month;
        protected override int MinutesInUnit => Minutes.InAMonth;
    }
}
