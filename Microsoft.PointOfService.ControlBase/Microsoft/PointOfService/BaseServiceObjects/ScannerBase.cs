namespace Microsoft.PointOfService.BaseServiceObjects
{
    public abstract class ScannerBase : Microsoft.PointOfService.BasicServiceObjects.ScannerBasic, System.IDisposable
    {
        protected ScannerBase()
        {
        }
        public override Microsoft.PointOfService.BarCodeSymbology ScanDataType
        {
            get { return Microsoft.PointOfService.BarCodeSymbology.Upca; }
        }
        public override System.Byte[] ScanData
        {
            get { return null; }
        }
        public override System.Byte[] ScanDataLabel
        {
            get { return null; }
        }
        public override System.Boolean DecodeData
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
