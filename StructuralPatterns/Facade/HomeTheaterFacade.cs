namespace StructuralPatterns.Facade
{

    // Facade que simplifica o uso
    public class HomeTheaterFacade
    {
        private DvdPlayer _dvdPlayer;
        private Projector _projector;
        private Lights _lights;
        private SoundSystem _soundSystem;

        public HomeTheaterFacade()
        {
            _dvdPlayer = new DvdPlayer();
            _projector = new Projector();
            _lights = new Lights();
            _soundSystem = new SoundSystem();
        }

        public void PlayMovie(string movie)
        {
            Console.WriteLine("Starting movie...");
            _lights.Dim(10);
            _projector.On();
            _projector.SetInput("DVD");
            _soundSystem.On();
            _soundSystem.SetVolume(20);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Ending movie...");
            _dvdPlayer.Stop();
            _dvdPlayer.Off();
            _soundSystem.Off();
            _projector.Off();
            _lights.On();
        }
    }
}