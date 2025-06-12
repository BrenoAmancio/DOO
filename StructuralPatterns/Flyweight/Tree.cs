namespace StructuralPatterns.Flyweight
{

    // Context - contém estado extrínseco
    public class Tree
    {
        private int _x;
        private int _y;
        private TreeType _type;

        public Tree(int x, int y, TreeType type)
        {
            _x = x;
            _y = y;
            _type = type;
        }

        public void Render()
        {
            _type.Render(_x, _y);
        }
    }
}