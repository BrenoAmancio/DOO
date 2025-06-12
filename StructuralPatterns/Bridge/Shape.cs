namespace StructuralPatterns.Bridge
{
    public abstract class Shape
    {
        protected IColor _color;

        protected Shape(IColor color)
        {
            _color = color;
        }

        public abstract void Draw();
    }
}