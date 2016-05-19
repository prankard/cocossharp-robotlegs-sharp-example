using CocosSharp;
using Robotlegs.Bender.Framework.Impl;
using Robotlegs.Bender.Bundles.MVCS;
using AirHockey.Windows.AirHockey.Config;

namespace AirHockey
{
    public class AppDelegate : CCApplicationDelegate
	{
        private Context context;

        public AppDelegate() : base()
        {
            context = new Context();
            context.Install<MVCSBundle>();
            context.Configure<AirHockeyMappings>();
            context.Configure<AddScenesConfig>();
        }

		/// <summary>
		///  Implement CCDirector and CCScene init code here.
		/// </summary>
		/// <returns>
		///  true  Initialize success, app continue.
		///  false Initialize failed, app terminate.
		/// </returns>
		public override void ApplicationDidFinishLaunching(CCApplication application, CCWindow mainWindow)
        {
            application.ContentRootDirectory = "Content";
            application.ContentSearchPaths.Add("SD");

            context.injector.Map<CCWindow>().ToValue(mainWindow);
            context.injector.Map<CCApplication>().ToValue(application);
            
            context.Initialize();
		}
	}
}