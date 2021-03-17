using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace MonteCarloConsole.Classes
{
    public class MonteCarlo
    {

        private int StartAmount { get;  }

        private int InvestmentAmount { get;  }

        public int TimePeriod { get;  }

        private string Rebalance { get;  }

        private double AverageReturn { get;  }

        private double StdDeviation { get; }

        public List<Simulation> Simulations = new List<Simulation>();

        public int SuccessfulSims { get; set; }

        public int MinResult
        {
            get
            {
                int minSim = Int32.MaxValue;

                foreach(Simulation sim in Simulations)
                {
                    if(sim.EndAmount < minSim)
                    {
                        minSim = sim.EndAmount;
                    }
                }

                return minSim;
            }
        }

        public int MaxResult
        {
            get
            {
                int maxSim = Int32.MinValue;

                foreach(Simulation sim in Simulations)
                {
                    if(sim.EndAmount > maxSim)
                    {
                        maxSim = sim.EndAmount;
                    }
                        
                }
                return maxSim;
            }
        }

        public int AverageResult
        {
            get
            {
                int sumResults = 0;

                foreach(Simulation sim in Simulations)
                {
                    sumResults += sim.EndAmount;
                }

                return sumResults / TotalSims;
            }
        }
        public int TotalSims
        {
            get
            {
                return Simulations.Count;
            }

            private set
            {
                TotalSims = value;
            }
        }

        public double SuccessRate
        {
            get
            {
                if(SuccessfulSims <= 0)
                {
                    return 0;
                }
                
                return ((double)SuccessfulSims / (double)TotalSims);
            }
        }

        public MonteCarlo()
        {

        }
 
        public MonteCarlo(int InitialValue, int AnnualWithdraw, int TimePeriod, string Rebalance,
                        double AverageReturn, double StdDeviation)
        {
            this.StartAmount = InitialValue;
            InvestmentAmount = AnnualWithdraw;
            this.TimePeriod = TimePeriod;
            this.Rebalance = Rebalance;
            this.AverageReturn = AverageReturn;
            this.StdDeviation = StdDeviation;
        }

        public string ReturnSample()
        {

            Random myrand = new Random();

            double result = Normal.Sample(myrand, AverageReturn, StdDeviation);
            
            return result.ToString();
        }

        public void RunOneSimulation()
        {
            Simulation thisSim = new Simulation(StartAmount, TimePeriod, InvestmentAmount, AverageReturn, StdDeviation);

            if (thisSim.RunSimulation())
            {
                SuccessfulSims += 1;
            }
            
            Simulations.Add(thisSim);

        }

        public void RunNumSimulations(int numToRun)
        {

            int numberRun = 0;

            while(numberRun < numToRun)
            {
                RunOneSimulation();

                numberRun++;

            }


        }




    }
}
