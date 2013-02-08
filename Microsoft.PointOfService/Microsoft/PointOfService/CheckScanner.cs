namespace Microsoft.PointOfService
{
    public class CheckScanner : Microsoft.PointOfService.PosCommon
    {
        protected CheckScanner()
        {
        }
        public const System.String StatisticChecksScannedCount = "ChecksScannedCount";
        public const System.Int32 CropAreaEntireImage = -1;
        public const System.Int32 CropAreaResetAll = -2;
        public const System.Int32 CropAreaRight = -1;
        public const System.Int32 CropAreaBottom = -1;
        public const System.Int32 AutomaticContrast = -1;
        public const System.Int32 ExtendedErrorNoCheck = 201;
        public const System.Int32 ExtendedErrorCheck = 202;
        public const System.Int32 ExtendedErrorNoRoom = 203;
        public const System.Int32 GetRawImageData = 1000;
        public const System.Int32 StatusScanComplete = 11;
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
        }
        public System.Boolean AutoDisable
        {
            get { return false; }
            set { }
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
        #pragma warning disable 67
        public event Microsoft.PointOfService.DataEventHandler DataEvent
        {
            add { }
            remove { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent
        {
            add { }
            remove { }
        }
        public virtual void ClearInput()
        {
        }
        public virtual void ClearInputProperties()
        {
        }
        public virtual void BeginInsertion(System.Int32 param_param_timeout)
        {
        }
        public virtual void BeginRemoval(System.Int32 param_param_timeout)
        {
        }
        public virtual void ClearImage(Microsoft.PointOfService.CheckImageClear param_param_by)
        {
        }
        public virtual void DefineCropArea(System.Int32 param_param_cropAreaId, System.Int32 param_param_x, System.Int32 param_param_y, System.Int32 param_param_width, System.Int32 param_param_height)
        {
        }
        public virtual void EndInsertion()
        {
        }
        public virtual void EndRemoval()
        {
        }
        public virtual void RetrieveImage(System.Int32 param_param_cropAreaId)
        {
        }
        public virtual void RetrieveMemory(Microsoft.PointOfService.CheckImageLocate param_param_by)
        {
        }
        public virtual void StoreImage(System.Int32 param_param_cropAreaId)
        {
        }
    }
}
