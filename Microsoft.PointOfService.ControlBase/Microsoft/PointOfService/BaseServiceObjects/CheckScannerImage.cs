namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class CheckScannerImage
    {
        public CheckScannerImage(System.Drawing.Bitmap param_imageData, System.String param_fileId, System.Int32 param_fileIndex, System.String param_imageTagData)
        {
        }
        protected CheckScannerImage()
        {
        }
        public System.Drawing.Bitmap ImageData
        {
            get { return null; }
        }
        public System.String FileId
        {
            get { return null; }
        }
        public System.Int32 FileIndex
        {
            get { return 0; }
        }
        public System.String ImageTagData
        {
            get { return null; }
        }
    }
}
