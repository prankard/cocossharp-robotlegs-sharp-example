using AirHockey.View;
using AirHockey.Windows.AirHockey.Model;
using CocosSharp;
using Robotlegs.Bender.Framework.API;

namespace AirHockey.Windows.AirHockey.Config
{
    public class AddScenesConfig : IConfig
    {
        [Inject]
        public GameModel gameModel;

        [Inject]
        public CCWindow mainWindow;

        [Inject]
        public CCApplication application;

        public void Configure()
        {
            CCScene scene = new CCScene(mainWindow);
            CCLayer layer = new IntroLayer(gameModel.DefaultResolution);

            scene.AddChild(layer);

            application.MainWindow.RunWithScene(scene);
        }
    }
}
