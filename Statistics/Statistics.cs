using System;
using System.Collections.Generic;
using System.Linq;
using static Stats;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
           Stats computeStatistics = new Stats();
           if (numbers.Count == 0)
           {
              computeStatistics.Average = (float)Double.NaN;
              computeStatistics.Min = (float)Double.NaN;
              computeStatistics.Max = (float)Double.NaN;
              return computeStatistics;  
           }
              computeStatistics.Average = numbers.Average();
              computeStatistics.Min = numbers.Min();
              computeStatistics.Max = numbers.Max();
              return computeStatistics;  
        }
    }
}
