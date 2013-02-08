namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class CheckScannerProperties : Microsoft.PointOfService.BasicServiceObjects.CommonProperties
    {
        protected CheckScannerProperties()
        {
        }
        public System.Boolean CapAutoGenerateFileId
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapAutoGenerateImageTagData
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapAutoSize
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.CheckColors CapColor
        {
            get { return Microsoft.PointOfService.CheckColors.Mono; }
            set { }
        }
        public System.Boolean CapConcurrentMicr
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapDefineCropArea
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.CheckImageFormats CapImageFormat
        {
            get { return Microsoft.PointOfService.CheckImageFormats.Native; }
            set { }
        }
        public System.Boolean CapImageTagData
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapMicrDevice
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapStoreImageFiles
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapValidationDevice
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.CheckColors Color
        {
            get { return Microsoft.PointOfService.CheckColors.Mono; }
            set { }
        }
        public System.Boolean ConcurrentMicr
        {
            get { return false; }
            set { }
        }
        public System.Int32 DocumentHeight
        {
            get { return 0; }
            set { }
        }
        public System.Int32 DocumentWidth
        {
            get { return 0; }
            set { }
        }
        public System.String FileId
        {
            get { return null; }
            set { }
        }
        public System.Int32 FileIndex
        {
            get { return 0; }
            set { }
        }
        public System.Drawing.Bitmap ImageData
        {
            get { return null; }
            set { }
        }
        public Microsoft.PointOfService.CheckImageFormats ImageFormat
        {
            get { return Microsoft.PointOfService.CheckImageFormats.Native; }
            set { }
        }
        public Microsoft.PointOfService.ImageMemoryStatus ImageMemoryStatus
        {
            get { return Microsoft.PointOfService.ImageMemoryStatus.Empty; }
            set { }
        }
        public System.String ImageTagData
        {
            get { return null; }
            set { }
        }
        public Microsoft.PointOfService.MapMode MapMode
        {
            get { return Microsoft.PointOfService.MapMode.Dots; }
            set { }
        }
        public System.Int32 MaxCropAreas
        {
            get { return 0; }
            set { }
        }
        public System.Int32 Quality
        {
            get { return 0; }
            set { }
        }
        public System.Int32[] QualityList
        {
            get { return null; }
            set { }
        }
        public System.Int32 RemainingImagesEstimate
        {
            get { return 0; }
            set { }
        }
        public System.Boolean CapAutoContrast
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapContrast
        {
            get { return false; }
            set { }
        }
        public System.Int32 Contrast
        {
            get { return 0; }
            set { }
        }
    }
}
