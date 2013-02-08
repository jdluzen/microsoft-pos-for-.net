namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class PosKeyboardBase : Microsoft.PointOfService.BasicServiceObjects.PosKeyboardBasic, System.IDisposable
    {
        protected PosKeyboardBase()
        {
        }
        public System.Boolean CapKeyUp
        {
            get { return false; }
        }
        public Microsoft.PointOfService.KeyboardEventType EventTypes
        {
            get { return Microsoft.PointOfService.KeyboardEventType.Down; }
            set { }
        }
        public System.Int32 PosKeyData
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.KeyEvent PosKeyEventType
        {
            get { return Microsoft.PointOfService.KeyEvent.Down; }
        }
        public override void Open()
        {
        }
    }
}
