namespace BehavioralPatterns.State
{

    // Context - Máquina de venda
    public class VendingMachine
    {
        private IState _currentState;

        public VendingMachine()
        {
            _currentState = new NoCoinState();
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public void InsertCoin()
        {
            _currentState.InsertCoin(this);
        }

        public void SelectProduct()
        {
            _currentState.SelectProduct(this);
        }

        public void DispenseProduct()
        {
            _currentState.DispenseProduct(this);
        }
    }
}