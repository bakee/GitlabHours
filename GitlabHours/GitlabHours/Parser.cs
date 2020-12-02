namespace GitlabHours
{
    public abstract class Parser : IParser
    {
        protected abstract string LogUnit { get; }
        protected abstract int MinutesInUnit { get; }
        public int Parse(string part)
        {
            var trimmedPart = part.Trim();
            if (trimmedPart.EndsWith(LogUnit))
            {
                var intPart = trimmedPart.Substring(0, trimmedPart.Length - LogUnit.Length);
                var intValue = int.Parse(intPart);
                return intValue * MinutesInUnit;
            }

            throw new NonParsablePartException();
        }
    }
}
