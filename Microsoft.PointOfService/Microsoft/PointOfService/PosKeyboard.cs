namespace Microsoft.PointOfService
{
    public class PosKeyboard : Microsoft.PointOfService.PosCommon
    {
        protected PosKeyboard()
        {
        }
        public const System.String StatisticKeyPressedCount = "KeyPressedCount";
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
        }
        public System.Boolean AutoDisable
        {
            get { return false; }
            set { }
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
        #pragma warning disable 67
        public event Microsoft.PointOfService.DataEventHandler DataEvent
        {
            add { }
            remove { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent
        {
            add { }
            remove { }
        }
        public virtual void ClearInput()
        {
        }
    }
}
