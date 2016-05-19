using AirHockey.View;
using AirHockey.View.Mediation;
using AirHockey.Windows.AirHockey.Model;
using CocosSharp;
using Robotlegs.Bender.Extensions.Mediation.API;
using Robotlegs.Bender.Framework.API;

namespace AirHockey.Windows.AirHockey.Config
{
    class AirHockeyMappings : IConfig
    {
        [Inject]
        public IInjector injector;

        [Inject]
        public IMediatorMap mediatorMap;

        [Inject]
        public CCWindow mainWindow;

        public void Configure()
        {
            GameModel gameModel = new GameModel();
            gameModel.DefaultResolution = new CCSize( mainWindow.WindowSizeInPixels.Width,
                mainWindow.WindowSizeInPixels.Height);

            injector.Map<GameModel>().ToValue(gameModel);
            mediatorMap.Map<GameSprite>().ToMediator<TintRedMediator>();
        }
    }
}
