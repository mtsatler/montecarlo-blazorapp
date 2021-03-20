using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloConsole.Classes
{
    public class Portfolio
    {
        private List<Asset> Assets = new List<Asset>();

        public double AverageReturn
        {
            get
            {
                double sum = 0;

                foreach (Asset a in Assets)
                {
                    sum += a.AverageReturn;
                }

                return sum / Assets.Count;
            }
            private set
            {
                AverageReturn = value;
            }

        }

        public double StdDeviation
        {
            get
            {
                double sum = 0;

                foreach(Asset a in Assets)
                {
                    sum += a.StdDev;
                }

                return sum / Assets.Count;
            }
            private set
            {
                StdDeviation = value;
            }
        }

        /// <summary>
        /// For custom setting of portfolio based on asset classes
        /// </summary>
        /// <param name="assetArray"></param>
        public Portfolio(Asset[] assetArray)
        {
            double totalAllocation = 0.0;

            foreach(Asset a in assetArray)
            {
                if(a.PercentAllocated + totalAllocation <= 1.00)
                {
                    Assets.Add(a);
                }
                else
                {
                    throw new Exception("Error creating portfolio. Asset allocation > 100%");
                }
            }

        }

        /// <summary>
        /// For non custom setting and provided only average return and stddev of portfolio
        /// </summary>
        /// <param name="avgReturn"></param>
        /// <param name="stdDev"></param>
        public Portfolio(double avgReturn, double stdDev)
        {
            AverageReturn = avgReturn;
            StdDeviation = stdDev;

        }
    }
}
