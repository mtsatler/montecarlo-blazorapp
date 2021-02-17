using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonteCarloBlazor.app.Shared
{
    public class StateContainer
    {

        public bool InputReceived { get; set; } = false;

        public int InitialValue { get; set; }

        public int AnnualWithdraw { get; set; }

        public int TimePeriod { get; set; }

        public string Rebalance { get; set; }

        public double AverageReturn { get; set; }

        public double StdDeviation { get; set; }

        public event Action OnChange;

        public void SetInputReceived(bool newValue, int initialValue, int AnnualWithdraw, int TimePeriod, string Rebalance,
                        double AverageReturn, double StdDeviation)
        {
            InputReceived = newValue;
            InitialValue = initialValue;
            this.AnnualWithdraw = AnnualWithdraw;
            this.TimePeriod = TimePeriod;
            this.Rebalance = Rebalance;
            this.AverageReturn = AverageReturn;
            this.StdDeviation = StdDeviation;

            NotifyStateChanged();
        }

        

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
