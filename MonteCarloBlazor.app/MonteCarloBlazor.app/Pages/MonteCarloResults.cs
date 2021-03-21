using MonteCarloConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonteCarloBlazor.app.Pages
{
    public partial class MonteCarloResults
    {

        
        private MonteCarlo MonteCarloSim = new MonteCarlo();

        private void InitMonteCarloSim()
        {
            MonteCarloSim = new MonteCarlo(
                StateContainer.InitialValue,
                StateContainer.AnnualWithdraw,
                StateContainer.TimePeriod,
                StateContainer.Rebalance,
                StateContainer.AverageReturn,
                StateContainer.StdDeviation);
        }

        protected override void OnInitialized()

        {
            StateContainer.OnChange += StateHasChanged;

        }

        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }

    }
}
