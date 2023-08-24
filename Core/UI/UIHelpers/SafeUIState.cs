namespace DestinyMod.Core.UI.UIHelpers
{
    public abstract class SafeUIState : UIState
    {
        protected virtual internal UserInterface uInterface { get; set; }

        public abstract int InsertionIndex(List<GameInterfaceLayer> layers);

        public virtual bool Visible { get; set; } = false;

        public virtual InterfaceScaleType ScaleType { get; set; } = InterfaceScaleType.UI;

        public virtual void Unload() { }

        internal void AddElement(UIElement element, int x, int y, int width, int height)
        {
            element.Left.Set(x, 0);
            element.Top.Set(y, 0);
            element.Width.Set(width, 0);
            element.Height.Set(height, 0);
            Append(element);
        }

        internal void AddElement(UIElement element, int x, int y, int width, int height, UIElement parent)
        {
            element.Left.Set(x, 0);
            element.Top.Set(y, 0);
            element.Width.Set(width, 0);
            element.Height.Set(height, 0);
            parent.Append(element);
        }

        internal void AddElement(UIElement element, int x, float xPerc, int y, float yPerc, int width, float widthPerc, int height, float heightPerc)
        {
            element.Left.Set(x, xPerc);
            element.Top.Set(y, yPerc);
            element.Width.Set(width, widthPerc);
            element.Height.Set(height, heightPerc);
            Append(element);
        }

        internal void AddElement(UIElement element, int x, float xPerc, int y, float yPerc, int width, float widthPerc, int height, float heightPerc, UIElement parent)
        {
            element.Left.Set(x, xPerc);
            element.Top.Set(y, yPerc);
            element.Width.Set(width, widthPerc);
            element.Height.Set(height, heightPerc);
            parent.Append(element);
        }

        #region LEFT CLICK VIRT

        public virtual void SafeClick(UIMouseEvent evt) { }

        public virtual void SafeDoubleClick(UIMouseEvent evt) { }

        public virtual void SafeMouseDown(UIMouseEvent evt) { }

        public virtual void SafeMouseOver(UIMouseEvent evt) { }

        public virtual void SafeMouseUp(UIMouseEvent evt) { }

        #endregion

        #region MIDDLE CLICK VIRT

        public virtual void SafeMiddleClick(UIMouseEvent evt) { }

        public virtual void SafeMiddleDoubleClick(UIMouseEvent evt) { }

        public virtual void SafeMiddleMouseDown(UIMouseEvent evt) { }

        public virtual void SafeMiddleMouseUp(UIMouseEvent evt) { }

        #endregion

        #region RIGHT CLICK VIRT

        public virtual void SafeRightClick(UIMouseEvent evt) { }

        public virtual void SafeRightDoubleClick(UIMouseEvent evt) { }

        public virtual void SafeRightMouseDown(UIMouseEvent evt) { }

        public virtual void SafeRightMouseUp(UIMouseEvent evt) { }

        #endregion

        #region MISC VIRT

        public virtual void SafeScrollWheel(UIScrollWheelEvent evt) { }

        public virtual void SafeUpdate(GameTime gameTime) { }

        #endregion

        #region XBUTTON1 VIRT

        public virtual void SafeXButton1Click(UIMouseEvent evt) { }

        public virtual void SafeXButton1DoubleClick(UIMouseEvent evt) { }

        public virtual void SafeXButton1MouseDown(UIMouseEvent evt) { }

        public virtual void SafeXButton1MouseUp(UIMouseEvent evt) { }

        #endregion

        #region XBUTTON2 VIRT

        public virtual void SafeXButton2Click(UIMouseEvent evt) { }

        public virtual void SafeXButton2DoubleClick(UIMouseEvent evt) { }

        public virtual void SafeXButton2MouseDown(UIMouseEvent evt) { }

        public virtual void SafeXButton2MouseUp(UIMouseEvent evt) { }

        #endregion

        #region OVERRIDES

        public sealed override void LeftClick(UIMouseEvent evt)
        {
            base.LeftClick(evt);
            SafeClick(evt);
        }

        public sealed override void LeftDoubleClick(UIMouseEvent evt)
        {
            base.LeftDoubleClick(evt);
            SafeDoubleClick(evt);
        }

        public sealed override void LeftMouseDown(UIMouseEvent evt)
        {
            base.LeftMouseDown(evt);
            SafeMouseDown(evt);
        }

        public sealed override void LeftMouseUp(UIMouseEvent evt)
        {
            base.LeftMouseUp(evt);
            SafeMouseUp(evt);
        }

        public sealed override void MiddleClick(UIMouseEvent evt)
        {
            base.MiddleClick(evt);
            SafeMiddleClick(evt);
        }

        public sealed override void MiddleDoubleClick(UIMouseEvent evt)
        {
            base.MiddleDoubleClick(evt);
            SafeMiddleDoubleClick(evt);
        }

        public sealed override void MiddleMouseDown(UIMouseEvent evt)
        {
            base.MiddleMouseDown(evt);
            SafeMiddleMouseDown(evt);
        }

        public sealed override void MiddleMouseUp(UIMouseEvent evt)
        {
            base.MiddleMouseUp(evt);
            SafeMiddleMouseUp(evt);
        }

        public sealed override void RightClick(UIMouseEvent evt)
        {
            base.RightClick(evt);
            SafeRightClick(evt);
        }

        public sealed override void RightDoubleClick(UIMouseEvent evt)
        {
            base.RightDoubleClick(evt);
            SafeRightDoubleClick(evt);
        }

        public sealed override void RightMouseDown(UIMouseEvent evt)
        {
            base.RightMouseDown(evt);
            SafeRightMouseDown(evt);
        }

        public sealed override void RightMouseUp(UIMouseEvent evt)
        {
            base.RightMouseUp(evt);
            SafeRightMouseUp(evt);
        }

        public sealed override void XButton1Click(UIMouseEvent evt)
        {
            base.XButton1Click(evt);
            SafeXButton1Click(evt);
        }

        public sealed override void XButton1DoubleClick(UIMouseEvent evt)
        {
            base.XButton1DoubleClick(evt);
            SafeXButton1DoubleClick(evt);
        }

        public sealed override void XButton1MouseDown(UIMouseEvent evt)
        {
            base.XButton1MouseDown(evt);
            SafeXButton1MouseDown(evt);
        }

        public sealed override void XButton1MouseUp(UIMouseEvent evt)
        {
            base.XButton1MouseUp(evt);
            SafeXButton1MouseUp(evt);
        }

        public sealed override void XButton2Click(UIMouseEvent evt)
        {
            base.XButton2Click(evt);
            SafeXButton2Click(evt);
        }

        public sealed override void XButton2DoubleClick(UIMouseEvent evt)
        {
            base.XButton2DoubleClick(evt);
            SafeXButton2DoubleClick(evt);
        }

        public sealed override void XButton2MouseDown(UIMouseEvent evt)
        {
            base.XButton2MouseDown(evt);
            SafeXButton2MouseDown(evt);
        }

        public sealed override void XButton2MouseUp(UIMouseEvent evt)
        {
            base.XButton2MouseUp(evt);
            SafeXButton2MouseUp(evt);
        }

        public sealed override void MouseOver(UIMouseEvent evt)
        {
            base.MouseOver(evt);
            SafeMouseOver(evt);
        }

        public sealed override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            SafeUpdate(gameTime);
        }

        public sealed override void ScrollWheel(UIScrollWheelEvent evt)
        {
            base.ScrollWheel(evt);
            SafeScrollWheel(evt);
        }

        #endregion
    }
}