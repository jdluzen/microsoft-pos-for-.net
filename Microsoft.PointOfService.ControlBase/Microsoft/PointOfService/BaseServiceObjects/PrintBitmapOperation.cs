namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class PrintBitmapOperation : Microsoft.PointOfService.BaseServiceObjects.PrintOperation
    {
        protected PrintBitmapOperation()
        {
        }
        public System.String FileName { get { return null; } }
        public System.Int32 Width { get { return 0; } }
        public System.Int32 Alignment { get { return 0; } }
    }
}
