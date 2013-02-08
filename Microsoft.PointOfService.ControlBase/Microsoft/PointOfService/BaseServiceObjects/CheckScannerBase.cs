namespace Microsoft.PointOfService.BaseServiceObjects
{
    public abstract class CheckScannerBase : Microsoft.PointOfService.BasicServiceObjects.CheckScannerBasic, System.IDisposable
    {
        protected CheckScannerBase()
        {
        }
        public override System.Boolean CapAutoGenerateFileId
        {
            get { return false; }
        }
        public override System.Boolean CapAutoGenerateImageTagData
        {
            get { return false; }
        }
        public override System.Boolean CapAutoSize
        {
            get { return false; }
        }
        public override Microsoft.PointOfService.CheckColors CapColor
        {
            get { return Microsoft.PointOfService.CheckColors.Mono; }
        }
        public override System.Boolean CapConcurrentMicr
        {
            get { return false; }
        }
        public override System.Boolean CapDefineCropArea
        {
            get { return false; }
        }
        public override Microsoft.PointOfService.CheckImageFormats CapImageFormat
        {
            get { return Microsoft.PointOfService.CheckImageFormats.Native; }
        }
        public override System.Boolean CapImageTagData
        {
            get { return false; }
        }
        public override System.Boolean CapMicrDevice
        {
            get { return false; }
        }
        public override System.Boolean CapStoreImageFiles
        {
            get { return false; }
        }
        public override System.Boolean CapValidationDevice
        {
            get { return false; }
        }
        public override Microsoft.PointOfService.CheckColors Color
        {
            get { return Microsoft.PointOfService.CheckColors.Mono; }
            set { }
        }
        public override System.Boolean ConcurrentMicr
        {
            get { return false; }
            set { }
        }
        public override System.Int32 CropAreaCount
        {
            get { return 0; }
        }
        public override System.Int32 DocumentHeight
        {
            get { return 0; }
            set { }
        }
        public override System.Int32 DocumentWidth
        {
            get { return 0; }
            set { }
        }
        public override System.String FileId
        {
            get { return null; }
            set { }
        }
        public override System.Int32 FileIndex
        {
            get { return 0; }
            set { }
        }
        public override System.Drawing.Bitmap ImageData
        {
            get { return null; }
        }
        public override Microsoft.PointOfService.CheckImageFormats ImageFormat
        {
            get { return Microsoft.PointOfService.CheckImageFormats.Native; }
            set { }
        }
        public override Microsoft.PointOfService.ImageMemoryStatus ImageMemoryStatus
        {
            get { return Microsoft.PointOfService.ImageMemoryStatus.Empty; }
        }
        public override System.String ImageTagData
        {
            get { return null; }
            set { }
        }
        public override Microsoft.PointOfService.MapMode MapMode
        {
            get { return Microsoft.PointOfService.MapMode.Dots; }
            set { }
        }
        public override System.Int32 MaxCropAreas
        {
            get { return 0; }
        }
        public override System.Int32 Quality
        {
            get { return 0; }
            set { }
        }
        public override System.Int32[] QualityList
        {
            get { return null; }
        }
        public override System.Int32 RemainingImagesEstimate
        {
            get { return 0; }
        }
        public override System.Boolean DeviceEnabled
        {
            get { return false; }
            set { }
        }
        public override System.Boolean CapAutoContrast
        {
            get { return false; }
        }
        public override System.Boolean CapContrast
        {
            get { return false; }
        }
        public override System.Int32 Contrast
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
