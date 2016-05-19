using CocosSharp;
using Robotlegs.Bender.Extensions.Mediation.API;
using Robotlegs.Bender.Extensions.ViewManagement.API;
using System;

namespace Robotlegs.Bender.Platforms.CocosSharp.Extensions.Mediation.Impl {
    public class CCSpriteView : CCSprite, IView 
    {
        public event Action<IView> RemoveView;

        public CCSpriteView() : base() { }
        public CCSpriteView(CCSpriteFrame spriteFrame) : base(spriteFrame) { }
        public CCSpriteView(CCSize contentSize, CCSpriteFrame spriteFrame) : base(contentSize, spriteFrame) { }
        public CCSpriteView(string fileName, CCRect? texRectInPixels = default(CCRect?)) : base(fileName, texRectInPixels) { }
        public CCSpriteView(CCTexture2D texture = null, CCRect? texRectInPixels = default(CCRect?), bool rotated = false) : base(texture, texRectInPixels, rotated) { }

        protected override void AddedToScene()
        {
            ViewNotifier.RegisterView(this);
            base.AddedToScene();
        }

        protected override void Dispose(bool disposing) 
        {
            if (RemoveView != null)
                RemoveView(this);

            base.Dispose(disposing);
        }
    }
}
