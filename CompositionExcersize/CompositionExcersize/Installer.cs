namespace CompositionExcersize
{
    partial class Program
    {
        public class Installer
        {
            private readonly Logger _logger;

            public Installer(Logger logger)
            {
                _logger = logger;
            }

            public void Instal()
            {
                _logger.Log("We are installing the application.");
            }
        }
    }
}
