using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace MonteCarloBlazor.app.Shared
{
    public class Simulation
    {

        public bool Result { get; set; }

        public int StartAmount { get; set; }

        public int ResultAmount { get; set; }

        public int InvestmentAmount { get; set; }

        public int NumYears { get; set; }

        List<SimYear> YearlyResults = new List<SimYear>();

        public double AverageReturn { get; set; }

        public double STDDeviation { get; set; }

        public Simulation()
        {
        }

        public Simulation(int startAmount,int numYears, int investmentAmount, double averageReturn, double STDDeviation)
        {
            StartAmount = startAmount;
            NumYears = numYears;
            AverageReturn = averageReturn;
            InvestmentAmount = investmentAmount;
            this.STDDeviation = STDDeviation;
        }

        private void RunSimulation()
        {
            Random rand = new Random();

            int initialAmount = StartAmount;

            for(int i = 0; i < NumYears; i++)
            {
                
                double growthRate = Normal.Sample(rand, AverageReturn, STDDeviation);
                SimYear thisYear = new SimYear(initialAmount,InvestmentAmount,growthRate);

                YearlyResults.Add(thisYear);

                initialAmount = thisYear._EndValue;
            }
        }

       

    }
}
