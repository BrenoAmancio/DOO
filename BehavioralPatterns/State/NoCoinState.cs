namespace BehavioralPatterns.State
{

    // Estados concretos
    public class NoCoinState : IState
    {
        public void InsertCoin(VendingMachine machine)
        {
            Console.WriteLine("Coin inserted.");
            machine.SetState(new HasCoinState());
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Insert coin first.");
        }

        public void DispenseProduct(VendingMachine machine)
        {
            Console.WriteLine("Insert coin first.");
        }
    }

}