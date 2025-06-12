namespace BehavioralPatterns.State
{
    public class HasCoinState : IState
    {
        public void InsertCoin(VendingMachine machine)
        {
            Console.WriteLine("Coin already inserted.");
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Product selected.");
            machine.SetState(new SoldState());
        }

        public void DispenseProduct(VendingMachine machine)
        {
            Console.WriteLine("Select product first.");
        }
    }
}