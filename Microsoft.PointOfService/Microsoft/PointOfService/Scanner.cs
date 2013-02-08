namespace Microsoft.PointOfService
{
    public class Scanner : Microsoft.PointOfService.PosCommon
    {
        protected Scanner()
        {
        }
        public const System.String StatisticGoodScanCount = "GoodScanCount";
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
        public System.Boolean DecodeData
        {
            get { return false; }
            set { }
        }
        public System.Byte[] ScanData
        {
            get { return null; }
        }
        public System.Byte[] ScanDataLabel
        {
            get { return null; }
        }
        public Microsoft.PointOfService.BarCodeSymbology ScanDataType
        {
            get { return Microsoft.PointOfService.BarCodeSymbology.Upca; }
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
