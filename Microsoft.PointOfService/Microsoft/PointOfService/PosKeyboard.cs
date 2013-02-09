namespace Microsoft.PointOfService
{
    public abstract class PosKeyboard : Microsoft.PointOfService.PosCommon
    {
        protected PosKeyboard()
        {
        }
        public const System.String StatisticKeyPressedCount = "KeyPressedCount";
        public abstract System.Int32 DataCount { get; }
        public abstract System.Boolean DataEventEnabled { get; set;  }
        public abstract System.Boolean AutoDisable { get; set;  }
        public abstract System.Boolean CapKeyUp { get; }
        public abstract Microsoft.PointOfService.KeyboardEventType EventTypes { get; set;  }
        public abstract System.Int32 PosKeyData { get; }
        public abstract Microsoft.PointOfService.KeyEvent PosKeyEventType { get; }
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DataEventHandler DataEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent;
        public virtual void ClearInput()
        {
        }
        
    }
}
