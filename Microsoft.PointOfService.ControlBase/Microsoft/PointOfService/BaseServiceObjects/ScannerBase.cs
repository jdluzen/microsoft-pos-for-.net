namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class ScannerBase : Microsoft.PointOfService.BasicServiceObjects.ScannerBasic, System.IDisposable
    {
        protected ScannerBase()
        {
        }
        public Microsoft.PointOfService.BarCodeSymbology ScanDataType
        {
            get { return Microsoft.PointOfService.BarCodeSymbology.Upca; }
        }
        public System.Byte[] ScanData
        {
            get { return null; }
        }
        public System.Byte[] ScanDataLabel
        {
            get { return null; }
        }
        public System.Boolean DecodeData
        {
            get { return false; }
            set { }
        }
        public override void ClearInputProperties()
        {
        }
        public override void Open()
        {
        }
    }
}
