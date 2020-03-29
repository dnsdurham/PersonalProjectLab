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
            #region Checks
            // Potential Exceptions
            // atBats does not equal zero
    
            // Potential invalid results
            // hits > atBats
            // hits and/or atBats are negative
            #endregion
    
            // Batting average is hits divided by at-bats
            decimal battingAverage = 0.000m;
    
            battingAverage = hits / (decimal)(atBats - walks);
    
            return battingAverage;
        }

        public decimal CalculateSluggingPercentage(int singles, int doubles, int triples, int homeRuns, int walks, int atBats)
        {

            #region Checks
            // Potential Exceptions
            // atBats does not equal zero
            // Potential invalid results
            // singles + doubles + triples + home runs > atBats
            // any input is negative
            #endregion

            // Slugging percentage is total bases divided by at bats
            decimal sluggingPercentage = 0.000m;
            int totalBases;

            totalBases = singles + (2 * doubles) + (3 * triples) + (4 * homeRuns);

            sluggingPercentage = totalBases / (decimal)(atBats-walks);

            return sluggingPercentage;
        }
    }
}
