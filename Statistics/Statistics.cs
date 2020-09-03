using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
           Stats computeStatistics = new Stats();
           if (numbers.Count == 0)
           {
              computeStatistics.Average = Double.NaN;
              computeStatistics.Min = Double.NaN;
              computeStatistics.Max = Double.NaN;
              return computeStatistics;  
           }
              computeStatistics.Average = numbers.Average();
              computeStatistics.Min = numbers.Min();
              computeStatistics.Max = numbers.Max();
              return computeStatistics;  
        }
    }
}
