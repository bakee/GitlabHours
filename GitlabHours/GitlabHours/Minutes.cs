namespace GitlabHours
{
    public static class Minutes
    {
        public const int InAnHour = 60;

        const int _hoursInADay = 8;
        public const int InADay = _hoursInADay * InAnHour;

        const int _daysInAWeek = 5;
        public const int InAWeek = _daysInAWeek * InADay;

        const int _weeksInAMonth = 4;
        public const int InAMonth = _weeksInAMonth * InAWeek;
    }
}
