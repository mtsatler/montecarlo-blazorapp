using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonteCarloBlazor.app.Shared
{
    public class SimYear
    {

        public int StartValue { get; set; }
        public int _EndValue { get; set; }
        private int EndValue
        {
            get
            {
                return (int)((StartValue * (1 + GrowthPercent)) + InvestmentAmount);
            }
            set
            {
                _EndValue = EndValue;
            }
        }

        public int InvestmentAmount { get; set; }
        public double GrowthPercent {get; set;} 

        public SimYear(int startValue, int investmentAmount, double growthPercent)
        {
            StartValue = startValue;
            InvestmentAmount = investmentAmount;
            GrowthPercent = growthPercent;
        }

      
    }
}
