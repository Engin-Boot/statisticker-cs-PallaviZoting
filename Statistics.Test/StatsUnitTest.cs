using System;
using Xunit;
using Statistics;

using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{1.5, 8.9, 3.2, 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(statsComputer.Average - 4.525) <= epsilon);
            Assert.True(Math.Abs(statsComputer.Max - 8.9) <= epsilon);
            Assert.True(Math.Abs(statsComputer.Min - 1.5) <= epsilon);
            Console.WriteLine("ReportsAverageMinMax Complete");
        }
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{});
            Assert.True((float)Double.IsNaN(computeStats.Average));
            Assert.True((float)Double.IsNaN(computeStats.Max));
            Assert.True((float)Double.IsNaN(computeStats.Min));
            Console.WriteLine("ReportsNaNForEmptyInput Complete");

            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }
    }
}
