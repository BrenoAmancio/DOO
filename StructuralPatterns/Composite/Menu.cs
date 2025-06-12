namespace StructuralPatterns.Composite
{
    public class Menu : IMenuComponent
    {
        private string _name;
        private List<IMenuComponent> _components = new List<IMenuComponent>();

        public Menu(string name)
        {
            _name = name;
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ', depth * 2)}{_name}");
            foreach (var component in _components)
            {
                component.Display(depth + 1);
            }
        }

        public void Add(IMenuComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IMenuComponent component)
        {
            _components.Remove(component);
        }
    }
}