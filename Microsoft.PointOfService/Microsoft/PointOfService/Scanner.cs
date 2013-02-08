namespace Microsoft.PointOfService
{
    public abstract class Scanner : Microsoft.PointOfService.PosCommon
    {
        protected Scanner()
        {
        }
        public const System.String StatisticGoodScanCount = "GoodScanCount";
        public abstract System.Int32 DataCount
        {
            get;
        }
        public abstract System.Boolean DataEventEnabled
        {
            get;
            set;
        }
        public abstract System.Boolean AutoDisable
        {
            get;
            set;
        }
        public abstract System.Boolean DecodeData
        {
            get;
            set;
        }
        public abstract System.Byte[] ScanData
        {
            get;
        }
        public abstract System.Byte[] ScanDataLabel
        {
            get;
        }
        public abstract Microsoft.PointOfService.BarCodeSymbology ScanDataType
        {
            get;
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
        public virtual void ClearInputProperties()
        {
        }
    }
}
