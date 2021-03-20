using MonteCarloConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonteCarloBlazor.app.Pages
{
    public partial class MonteCarloResults
    {

        private int InitialValue { get; set; }

        public int AnnualWithdraw { get; set; }

        public int TimePeriod { get; set; }

        public string Rebalance { get; set; }

        public double AverageReturn { get; set; }

        public double StdDeviation { get; set; }

        private MonteCarlo MonteCarloSim = new MonteCarlo();

        private void GetInputFromStateContainer()
        {
            InitialValue = StateContainer.InitialValue;
            AnnualWithdraw = StateContainer.AnnualWithdraw;
            TimePeriod = StateContainer.TimePeriod;
            Rebalance = StateContainer.Rebalance;
            AverageReturn = StateContainer.AverageReturn;
            StdDeviation = StateContainer.StdDeviation;

            MonteCarloSim = new MonteCarlo(InitialValue, AnnualWithdraw, TimePeriod, Rebalance,
                           AverageReturn, StdDeviation);

            //testString = MonteCarloSim.ReturnSample();
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
