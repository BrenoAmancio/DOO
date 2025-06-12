namespace StructuralPatterns.Proxy
{

    // Proxy que controla acesso à imagem real
    public class ProxyImage : IImage
    {
        private string _filename;
        private RealImage _realImage;

        public ProxyImage(string filename)
        {
            _filename = filename;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
            }
            _realImage.Display();
        }
    }
}