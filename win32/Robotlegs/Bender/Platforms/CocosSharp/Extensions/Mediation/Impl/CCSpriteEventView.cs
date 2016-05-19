using CocosSharp;
using Robotlegs.Bender.Extensions.EventManagement.API;
using Robotlegs.Bender.Extensions.EventManagement.Impl;

namespace Robotlegs.Bender.Platforms.CocosSharp.Extensions.Mediation.Impl
{
    public class CCSpriteEventView : CCSpriteView
    {
        public CCSpriteEventView() : base() { }
        public CCSpriteEventView(CCSpriteFrame spriteFrame) : base(spriteFrame) { }
        public CCSpriteEventView(CCSize contentSize, CCSpriteFrame spriteFrame) : base(contentSize, spriteFrame) { }
        public CCSpriteEventView(string fileName, CCRect? texRectInPixels = default(CCRect?)) : base(fileName, texRectInPixels) { }
        public CCSpriteEventView(CCTexture2D texture = null, CCRect? texRectInPixels = default(CCRect?), bool rotated = false) : base(texture, texRectInPixels, rotated) { }

        private IEventDispatcher _dispatcher = new EventDispatcher();
        public IEventDispatcher dispatcher
        {
            get
            {
                return _dispatcher;
            }
            set
            {
                _dispatcher = value;
            }
        }
    }
}
