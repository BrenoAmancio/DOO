namespace StructuralPatterns.Flyweight
{
    // Flyweight - estado intrínseco compartilhado
    public class TreeType
    {
        private string _name;
        private string _color;
        private string _texture;

        public TreeType(string name, string color, string texture)
        {
            _name = name;
            _color = color;
            _texture = texture;
        }

        public void Render(int x, int y)
        {
            Console.WriteLine($"Rendering {_name} tree ({_color}, {_texture}) at position ({x}, {y})");
        }
    }
}