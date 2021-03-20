using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonteCarloBlazor.app.Pages
{
    public partial class UserInput
    {

        private int initialValue { get; set; }

        private int annualWithdrawal { get; set; }

        private double averageReturn { get; set; }

        private double standardDev { get; set; }
 
        private int yearsToSim { get; set; } = 10;

        private string getWithdrawalAmount;

        private string getPortfolioAmount;

        private string getAverageReturn;

        private string getStandardDev;

        
        private string rebalancingSelection { get; set; } = "None";

        private void GetUserInput()
        {
            initialValue = int.Parse(getPortfolioAmount);
            annualWithdrawal = int.Parse(getWithdrawalAmount);
            averageReturn = double.Parse(getAverageReturn);
            standardDev = double.Parse(getStandardDev);
        }

        private void SendUserInput()
        {
            GetUserInput();
            StateContainer.SetInputReceived(true, initialValue, annualWithdrawal, yearsToSim, rebalancingSelection, averageReturn, standardDev);
        }

        private void GetRebalancingSelection(ChangeEventArgs args)
        {
            rebalancingSelection = args.Value.ToString();
        }

        private void GetYearsToSimSelection(ChangeEventArgs args)
        {
            yearsToSim = int.Parse(args.Value.ToString());
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
