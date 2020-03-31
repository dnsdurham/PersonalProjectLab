using System;
namespace PersonalProjectLab
{
    public class BaseballStats
    {
        public BaseballStats()
        {
        }

        public decimal CalculateBattingAverage(int hits, int walks, int atBats)
        {
            // batting average = hits / (at bats - walks)
            decimal avg = 0.00m;

            avg = hits / (decimal)(atBats - walks);

            return avg;
        }

        public decimal CalculateSluggingPercentage(int singles, int doubles, int triples, int homeRuns, int walks, int atBats)
        {
            // slugging percentage is total bases divided by at bats minus walks
            decimal sluggingPercentage = 0.00m;
            int totalBases;

            totalBases = singles + (2 * doubles) + (3 * triples) + (4 * homeRuns);

            sluggingPercentage = totalBases / (decimal)(atBats - walks);

            return sluggingPercentage;
        }
    }
}
