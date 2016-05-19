using Robotlegs.Bender.Bundles.MVCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirHockey.View.Mediation {
    class TintRedMediator : Mediator
    {
        [Inject]
        public GameSprite view;
        
        public override void Initialize()
        {
            Console.WriteLine("Mediated");
            CocosSharp.CCColor3B color = new CocosSharp.CCColor3B(255, 0, 0);
            view.Color = color;
            base.Initialize();
        }
    }
}
