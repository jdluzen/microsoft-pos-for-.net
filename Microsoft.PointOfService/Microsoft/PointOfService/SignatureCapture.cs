namespace Microsoft.PointOfService
{
    public class SignatureCapture : Microsoft.PointOfService.PosCommon
    {
        protected SignatureCapture()
        {
        }
        public const System.String StatisticGoodSignatureReadCount = "GoodSignatureReadCount";
        public const System.String StatisticFailedSignatureReadCount = "FailedSignatureReadCount";
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
        public System.Boolean CapDisplay
        {
            get { return false; }
        }
        public System.Boolean CapRealTimeData
        {
            get { return false; }
        }
        public System.Boolean CapUserTerminated
        {
            get { return false; }
        }
        public System.Int32 MaximumX
        {
            get { return 0; }
        }
        public System.Int32 MaximumY
        {
            get { return 0; }
        }
        public System.Drawing.Point[] PointArray
        {
            get { return null; }
        }
        public System.Byte[] RawData
        {
            get { return null; }
        }
        public System.Boolean RealTimeDataEnabled
        {
            get { return false; }
            set { }
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
        public virtual void BeginCapture(System.String param_param_formName)
        {
        }
        public virtual void EndCapture()
        {
        }
    }
}
