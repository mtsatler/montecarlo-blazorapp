using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloConsole.Classes
{
    public class Asset
    {

        public string AssetName { get; }
        public double AverageReturn { get; }
        public double StdDev { get;  }  
        public double PercentAllocated { get; }

        public Asset(string assetName, double averageReturn, double stdDev, double percentAllocation)
        {
            AssetName = assetName;
            AverageReturn = averageReturn;
            StdDev = stdDev;

            if(percentAllocation <= 1.00)
            {
                PercentAllocated = percentAllocation;
            }
            
        }


    }
}
