namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class PosKeyboardProperties : Microsoft.PointOfService.BasicServiceObjects.CommonProperties
    {
        protected PosKeyboardProperties()
        {
        }
        public System.Boolean CapKeyUp
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.KeyboardEventType EventTypes
        {
            get { return Microsoft.PointOfService.KeyboardEventType.Down; }
            set { }
        }
        public System.Int32 PosKeyData
        {
            get { return 0; }
            set { }
        }
        public Microsoft.PointOfService.KeyEvent PosKeyEventType
        {
            get { return Microsoft.PointOfService.KeyEvent.Down; }
            set { }
        }
    }
}
