namespace Microsoft.PointOfService
{
    public abstract class SignatureCapture : Microsoft.PointOfService.PosCommon
    {
        protected SignatureCapture()
        {
        }
        public const System.String StatisticGoodSignatureReadCount = "GoodSignatureReadCount";
        public const System.String StatisticFailedSignatureReadCount = "FailedSignatureReadCount";
        public abstract System.Int32 DataCount { get; }
        public abstract System.Boolean DataEventEnabled { get; set;  }
        public abstract System.Boolean AutoDisable { get; set;  }
        public abstract System.Boolean CapDisplay { get; }
        public abstract System.Boolean CapRealTimeData { get; }
        public abstract System.Boolean CapUserTerminated { get; }
        public abstract System.Int32 MaximumX { get; }
        public abstract System.Int32 MaximumY { get; }
        public abstract System.Drawing.Point[] PointArray { get; }
        public abstract System.Byte[] RawData { get; }
        public abstract System.Boolean RealTimeDataEnabled { get; set;  }
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DataEventHandler DataEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent;
        public virtual void ClearInput()
        {
        }
        
        public virtual void ClearInputProperties()
        {
        }
        
        public virtual void BeginCapture(System.String formName)
        {
        }
        
        public virtual void EndCapture()
        {
        }
        
    }
}
