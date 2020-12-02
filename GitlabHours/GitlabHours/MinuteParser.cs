namespace GitlabHours
{
    public class MinuteParser : Parser
    {
        protected override string LogUnit => GitlabHours.LogUnit.Minute;
        protected override int MinutesInUnit => 1;
    }
}
