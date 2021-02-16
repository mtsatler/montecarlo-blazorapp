using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonteCarloBlazor.app.Shared
{
    public class StateContainer
    {

        public bool InputReceived { get; set; } = false;

        public event Action OnChange;

        public void SetInputReceived(bool newValue)
        {
            InputReceived = newValue;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
