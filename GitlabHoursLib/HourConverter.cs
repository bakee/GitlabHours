using System;
using System.Collections.Generic;

namespace GitlabHoursLib
{
    public class HourConverter
    {
        private readonly IList<IParser> _parserList;
        public HourConverter()
        {
            _parserList = new List<IParser>
            {
                new MonthParser(),
                new WeekParser(),
                new DayParser(),
                new HourParser(),
                new MinuteParser(),
            };
        }

        public string Convert(string input)
        {
            var parts = input.Split(' ');
            var totalMinutes = 0;
            foreach (var part in parts)
            {
                totalMinutes += Parse(part);
            }

            return FormatMinutes(input, totalMinutes);
        }

        private static string FormatMinutes(string input, int totalMinutes)
        {
            if (totalMinutes == 0)
            {
                return "";
            }

            var totalHours = Math.DivRem(totalMinutes, 60, out int minutes);

            var output = "";
            if (totalHours != 0)
            {
                output = $"{totalHours}h";
            }

            if (minutes != 0)
            {
                output = $"{output} {minutes}m";
            }

            return $"{input} -> {output}";
        }

        private int Parse(string part)
        {
            var parsedMinutes = 0;

            foreach (var parser in _parserList)
            {
                try
                {
                    parsedMinutes = parser.Parse(part);
                    break;
                }
                catch (NonParsablePartException)
                {
                    continue;
                }
                catch (Exception)
                {
                    break;
                }
            }

            return parsedMinutes;
        }
    }
}
