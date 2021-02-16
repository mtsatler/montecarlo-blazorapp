using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MonteCarloBlazor.app.Shared
{
    public class MonteCarlo
    {

        private int InitialValue { get;  }

        private int AnnualWithdraw { get;  }

        private int TimePeriod { get;  }

        private string Rebalance { get;  }

        private double AverageReturn { get;  }

        private double StdDeviation { get; }


        public MonteCarlo(int InitialValue, int AnnualWithdraw, int TimePeriod, string Rebalance,
                        double AverageReturn, double StdDeviation)
        {
            this.InitialValue = InitialValue;
            this.AnnualWithdraw = AnnualWithdraw;
            this.TimePeriod = TimePeriod;
            this.Rebalance = Rebalance;
            this.AverageReturn = AverageReturn;
            this.StdDeviation = StdDeviation;
        }




    }
}
