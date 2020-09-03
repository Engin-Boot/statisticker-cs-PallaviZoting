using System;
using Xunit;
using Statistics;
using System.Collections.Generic;
using static Statistics.Stats;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<float>{1.5F, 8.9F, 3.2F, 4.5F});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.Average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.Max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.Min - 1.5) <= epsilon);
            Console.WriteLine("ReportsAverageMinMax Complete");
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<float>{});
            Assert.True(Double.IsNaN(computedStats.Average));
            Assert.True(Double.IsNaN(computedStats.Max));
            Assert.True(Double.IsNaN(computedStats.Min));
            Console.WriteLine("ReportsNaNForEmptyInput Complete");

            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }
        [Fact]
        public void WhenInputHavingOneOrMoreNanThenReturnStatisticsOfRemainingNumbers()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<float>{1.5F, float.NaN, 3.2F, 4.5F});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.Average - 3.067F) <= epsilon);
            Assert.True(Math.Abs(computedStats.Max - 4.5F) <= epsilon);
            Assert.True(Math.Abs(computedStats.Min - 1.5F) <= epsilon);
            Console.WriteLine("ReportsAverageMinMax Complete");
        }
    }
}
