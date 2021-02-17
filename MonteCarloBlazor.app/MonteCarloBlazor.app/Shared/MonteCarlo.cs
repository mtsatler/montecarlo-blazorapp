using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;


namespace MonteCarloBlazor.app.Shared
{
    public class MonteCarlo
    {

        private int StartAmount { get;  }

        private int InvestmentAmount { get;  }

        private int TimePeriod { get;  }

        private string Rebalance { get;  }

        private double AverageReturn { get;  }

        private double StdDeviation { get; }

        public List<Simulation> Simulations = new List<Simulation>(); 

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

            Simulations.Add(thisSim);

        }

    }
}
