namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class PrintMemoryBitmapOperation : Microsoft.PointOfService.BaseServiceObjects.PrintOperation
    {
        protected PrintMemoryBitmapOperation()
        {
        }
        public System.Drawing.Bitmap Bitmap { get { return null; } }
        public System.Int32 Width { get { return 0; } }
        public System.Int32 Alignment { get { return 0; } }
    }
}
