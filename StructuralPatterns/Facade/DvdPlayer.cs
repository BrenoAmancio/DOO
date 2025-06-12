namespace StructuralPatterns.Facade
{
    // Subsistemas complexos
    public class DvdPlayer
    {
        public void On() => Console.WriteLine("DVD Player on");
        public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
        public void Stop() => Console.WriteLine("DVD Player stopped");
        public void Off() => Console.WriteLine("DVD Player off");
    }
}