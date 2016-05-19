using CocosSharp;

namespace AirHockey
{
    static class Program
	{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
		{
			CCApplication application = new CCApplication(false, new CCSize(768f, 1024f));
			application.ApplicationDelegate = new AppDelegate();
			application.StartGame();
		}
	}
}

