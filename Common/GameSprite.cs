using CocosSharp;
using Robotlegs.Bender.Platforms.CocosSharp.Extensions.Mediation.Impl;

namespace AirHockey.View
{
    class GameSprite : CCSpriteView
    {
        
        public float radius { get { return ContentSize.Width * 0.5f; } }

        public CCTouch Touch { get; set; }
        public CCPoint NextPosition { get; set; }
        public CCPoint Vector { get; set; }

        public GameSprite(string url):base(url)
        {
            NextPosition = Position;
        }

        public void SetPosition(CCPoint pos)
        {
            Position = pos;
            if (NextPosition != pos)
            {
                NextPosition = pos;
            }
        }
    }
}
