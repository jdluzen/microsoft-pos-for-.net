namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class CheckScannerBase : Microsoft.PointOfService.BasicServiceObjects.CheckScannerBasic, System.IDisposable
    {
        protected CheckScannerBase()
        {
        }
        public System.Boolean CapAutoGenerateFileId
        {
            get { return false; }
        }
        public System.Boolean CapAutoGenerateImageTagData
        {
            get { return false; }
        }
        public System.Boolean CapAutoSize
        {
            get { return false; }
        }
        public Microsoft.PointOfService.CheckColors CapColor
        {
            get { return Microsoft.PointOfService.CheckColors.Mono; }
        }
        public System.Boolean CapConcurrentMicr
        {
            get { return false; }
        }
        public System.Boolean CapDefineCropArea
        {
            get { return false; }
        }
        public Microsoft.PointOfService.CheckImageFormats CapImageFormat
        {
            get { return Microsoft.PointOfService.CheckImageFormats.Native; }
        }
        public System.Boolean CapImageTagData
        {
            get { return false; }
        }
        public System.Boolean CapMicrDevice
        {
            get { return false; }
        }
        public System.Boolean CapStoreImageFiles
        {
            get { return false; }
        }
        public System.Boolean CapValidationDevice
        {
            get { return false; }
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
        public System.Int32 CropAreaCount
        {
            get { return 0; }
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
        }
        public Microsoft.PointOfService.CheckImageFormats ImageFormat
        {
            get { return Microsoft.PointOfService.CheckImageFormats.Native; }
            set { }
        }
        public Microsoft.PointOfService.ImageMemoryStatus ImageMemoryStatus
        {
            get { return Microsoft.PointOfService.ImageMemoryStatus.Empty; }
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
        }
        public System.Int32 Quality
        {
            get { return 0; }
            set { }
        }
        public System.Int32[] QualityList
        {
            get { return null; }
        }
        public System.Int32 RemainingImagesEstimate
        {
            get { return 0; }
        }
        public System.Boolean DeviceEnabled
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapAutoContrast
        {
            get { return false; }
        }
        public System.Boolean CapContrast
        {
            get { return false; }
        }
        public System.Int32 Contrast
        {
            get { return 0; }
            set { }
        }
        public override void Open()
        {
        }
        public override void ClearInputProperties()
        {
        }
        public override void BeginInsertion(System.Int32 timeout)
        {
        }
        public override void BeginRemoval(System.Int32 timeout)
        {
        }
        public override void ClearImage(Microsoft.PointOfService.CheckImageClear by)
        {
        }
        public override void DefineCropArea(System.Int32 cropAreaId, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
        {
        }
        public override void EndInsertion()
        {
        }
        public override void EndRemoval()
        {
        }
        public override void RetrieveImage(System.Int32 cropAreaId)
        {
        }
        public override void RetrieveMemory(Microsoft.PointOfService.CheckImageLocate by)
        {
        }
        public override void StoreImage(System.Int32 cropAreaId)
        {
        }
    }
}
