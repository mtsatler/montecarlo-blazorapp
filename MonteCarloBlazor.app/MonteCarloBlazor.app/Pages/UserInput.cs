using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonteCarloBlazor.app.Pages
{
    public partial class UserInput
    {

        private string inputWithdrawalAmount
        {
            get
            {
                return StateContainer.AnnualWithdraw.ToString();
            }
            set
            {
                StateContainer.AnnualWithdraw = int.Parse(value);
                StateContainer.NotifyStateChanged();
            }
        }

        private string inputPortfolioAmount
        {
            get
            {
                return StateContainer.InitialValue.ToString();
            }
            set
            {
                StateContainer.InitialValue = int.Parse(value);
                StateContainer.NotifyStateChanged();
            }
        }

        //radio button selection to determine which razor component to use
        private string allocationType;

        private void RunMonteCarloSim()
        {
            StateContainer.InputReceived = true;
            StateContainer.NotifyStateChanged();
        }

        private void GetYearsToSimSelection(ChangeEventArgs args)
        {
            StateContainer.TimePeriod = int.Parse(args.Value.ToString());
        }

        private void AllocationSwitch(ChangeEventArgs args)
        {
            allocationType = args.Value.ToString();
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
