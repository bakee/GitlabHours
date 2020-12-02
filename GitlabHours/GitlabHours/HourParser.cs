namespace GitlabHours
{
    public class HourParser : Parser
    {
        protected override string LogUnit => GitlabHours.LogUnit.Hour;
        protected override int MinutesInUnit => Minutes.InAnHour;
    }
}
