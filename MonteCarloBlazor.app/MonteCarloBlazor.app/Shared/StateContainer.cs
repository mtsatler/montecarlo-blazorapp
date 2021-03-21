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

        public int TimePeriod { get; set; } = 10;

        public string Rebalance { get; set; }

        public double AverageReturn { get; set; }

        public double StdDeviation { get; set; }

        public event Action OnChange;

        public void NotifyStateChanged() => OnChange?.Invoke();

    }
}
