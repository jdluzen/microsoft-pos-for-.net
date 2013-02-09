namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class CheckScannerImage
    {
        public CheckScannerImage(System.Drawing.Bitmap imageData, System.String fileId, System.Int32 fileIndex, System.String imageTagData)
        {
        }
        
        protected CheckScannerImage()
        {
        }
        public System.Drawing.Bitmap ImageData { get { return null; } }
        public System.String FileId { get { return null; } }
        public System.Int32 FileIndex { get { return 0; } }
        public System.String ImageTagData { get { return null; } }
    }
}
