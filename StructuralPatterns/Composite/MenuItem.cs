namespace StructuralPatterns.Composite
{

    public class MenuItem : IMenuComponent
    {
        private string _name;
        private decimal _price;

        public MenuItem(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ', depth * 2)}{_name} - ${_price}");
        }

        public void Add(IMenuComponent component)
        {
            throw new NotSupportedException("Cannot add items to a menu item");
        }

        public void Remove(IMenuComponent component)
        {
            throw new NotSupportedException("Cannot remove items from a menu item");
        }
    }
}