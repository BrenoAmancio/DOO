namespace StructuralPatterns.Facade
{

    public class SoundSystem
    {
        public void On() => Console.WriteLine("Sound system on");
        public void SetVolume(int volume) => Console.WriteLine($"Volume set to {volume}");
        public void Off() => Console.WriteLine("Sound system off");
    }
}