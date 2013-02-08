namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class ScannerProperties : Microsoft.PointOfService.BasicServiceObjects.CommonProperties
    {
        protected ScannerProperties()
        {
        }
        public Microsoft.PointOfService.BarCodeSymbology ScanDataType
        {
            get { return Microsoft.PointOfService.BarCodeSymbology.Upca; }
            set { }
        }
        public System.Byte[] ScanData
        {
            get { return null; }
            set { }
        }
        public System.Byte[] ScanDataLabel
        {
            get { return null; }
            set { }
        }
    }
}
