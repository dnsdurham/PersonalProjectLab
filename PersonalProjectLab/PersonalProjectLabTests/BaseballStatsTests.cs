using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class BaseballStatsTests
    {
        [TestMethod]
        public void BaseballStats_CalculateBattingAverage()
        {
            // arrange
            BaseballStats stats = new BaseballStats();

            // act
            decimal avg = stats.CalculateBattingAverage(25, 5, 105);

            //asserting
            Assert.AreEqual(.250m, avg);
        }

        [TestMethod]
        public void BaseballStats_SluggingPercentage()
        {
            // arrange
            BaseballStats stats = new BaseballStats();

            // act
            decimal slugging = stats.CalculateSluggingPercentage(15, 10, 3, 1, 5, 105);

            //asserting
            Assert.AreEqual(.480m, slugging);
        }
    }
}
