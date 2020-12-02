namespace GitlabHoursLib
{
    public class MinuteParser : Parser
    {
        protected override string LogUnit => GitlabHoursLib.LogUnit.Minute;
        protected override int MinutesInUnit => 1;
    }
}
