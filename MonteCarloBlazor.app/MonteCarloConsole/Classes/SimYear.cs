using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonteCarloConsole.Classes
{
    public class SimYear
    {

        public int StartValue { get; set; }
        public int EndValue { get { return _EndValue; } }

        private int _EndValue { get; set; }

        public int InvestmentAmount { get; set; }
        public double GrowthPercent {get; set;} 

        public SimYear(int startValue, int investmentAmount, double growthPercent)
        {
            StartValue = startValue;
            InvestmentAmount = investmentAmount;
            GrowthPercent = growthPercent;

            _EndValue = (int)(StartValue * (1.00 + GrowthPercent)) + InvestmentAmount;
        }

      
    }
}
