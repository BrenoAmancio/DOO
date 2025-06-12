namespace StructuralPatterns.Proxy
{
    // Imagem real que carrega recurso pesado
    public class RealImage : IImage
    {
        private string _filename;

        public RealImage(string filename)
        {
            _filename = filename;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image: {_filename}");
            // Simula carregamento pesado
            Thread.Sleep(1000);
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {_filename}");
        }
    }
}