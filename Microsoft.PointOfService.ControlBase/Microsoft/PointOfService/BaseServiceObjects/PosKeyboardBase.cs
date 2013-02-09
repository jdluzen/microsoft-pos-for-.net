namespace Microsoft.PointOfService.BaseServiceObjects
{
    public abstract class PosKeyboardBase : Microsoft.PointOfService.BasicServiceObjects.PosKeyboardBasic, System.IDisposable
    {
        protected PosKeyboardBase()
        {
        }
        public override System.Boolean CapKeyUp { get { return false; } }
        public override Microsoft.PointOfService.KeyboardEventType EventTypes { get { return Microsoft.PointOfService.KeyboardEventType.Down; } set { } }
        public override System.Int32 PosKeyData { get { return 0; } }
        public override Microsoft.PointOfService.KeyEvent PosKeyEventType { get { return Microsoft.PointOfService.KeyEvent.Down; } }
        public override void Open()
        {
        }
        
    }
}
