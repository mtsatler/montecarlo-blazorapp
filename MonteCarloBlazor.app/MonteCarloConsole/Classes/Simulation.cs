using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace MonteCarloConsole.Classes
{
    public class Simulation
    {

        public List<SimYear> YearlyResults = new List<SimYear>();
        public bool Result { get; set; } 

        public int StartAmount { get; set; }

        public int EndAmount { get; set; }

        public int InvestmentAmount { get; set; }

        public int NumYears { get; set; }

        public double AverageReturn { get; set; }

        public double STDDeviation { get; set; }

        public bool Successful { get; set; } = true;

        public int FailureYear { get; set; }

        public Simulation()
        {
        }

        public Simulation(int startAmount,int numYears, int investmentAmount, Portfolio InvestmentPortfolio)
        {
            StartAmount = startAmount;
            NumYears = numYears;
            AverageReturn = InvestmentPortfolio.AverageReturn;
            InvestmentAmount = investmentAmount;
            this.STDDeviation = InvestmentPortfolio.StdDeviation;
        }

     
        public bool RunSimulation()
        {
            Random rand = new Random();

            int initialAmount = StartAmount;

            for(int i = 0; i < NumYears; i++)
            {
                
                double growthRate = Normal.Sample(rand, AverageReturn, STDDeviation);
                SimYear thisYear = new SimYear(initialAmount,InvestmentAmount,growthRate);

                if(thisYear.EndValue <= 0)
                {
                    Successful = false;
                    YearlyResults.Add(thisYear);
                    FailureYear = i + 1;
                    return false;
                }
                

                if (thisYear.EndValue < 0)
                {
                    return false;
                }

                initialAmount = thisYear.EndValue;

            }

            EndAmount = initialAmount;

            if(EndAmount > 0)
            {
                Result = true;
            }
            else
            {
                Result = false;
            }

            return Result;
        }

       

    }
}
