namespace Microsoft.PointOfService
{
    public abstract class CheckScanner : Microsoft.PointOfService.PosCommon
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
        public abstract System.Int32 DataCount
        {
            get;
        }
        public abstract System.Boolean DataEventEnabled
        {
            get;
            set;
        }
        public abstract System.Boolean AutoDisable
        {
            get;
            set;
        }
        public abstract System.Boolean CapAutoGenerateFileId
        {
            get;
        }
        public abstract System.Boolean CapAutoGenerateImageTagData
        {
            get;
        }
        public abstract System.Boolean CapAutoSize
        {
            get;
        }
        public abstract Microsoft.PointOfService.CheckColors CapColor
        {
            get;
        }
        public abstract System.Boolean CapConcurrentMicr
        {
            get;
        }
        public abstract System.Boolean CapDefineCropArea
        {
            get;
        }
        public abstract Microsoft.PointOfService.CheckImageFormats CapImageFormat
        {
            get;
        }
        public abstract System.Boolean CapImageTagData
        {
            get;
        }
        public abstract System.Boolean CapMicrDevice
        {
            get;
        }
        public abstract System.Boolean CapStoreImageFiles
        {
            get;
        }
        public abstract System.Boolean CapValidationDevice
        {
            get;
        }
        public abstract Microsoft.PointOfService.CheckColors Color
        {
            get;
            set;
        }
        public abstract System.Boolean ConcurrentMicr
        {
            get;
            set;
        }
        public abstract System.Int32 CropAreaCount
        {
            get;
        }
        public abstract System.Int32 DocumentHeight
        {
            get;
            set;
        }
        public abstract System.Int32 DocumentWidth
        {
            get;
            set;
        }
        public abstract System.String FileId
        {
            get;
            set;
        }
        public abstract System.Int32 FileIndex
        {
            get;
            set;
        }
        public abstract System.Drawing.Bitmap ImageData
        {
            get;
        }
        public abstract Microsoft.PointOfService.CheckImageFormats ImageFormat
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.ImageMemoryStatus ImageMemoryStatus
        {
            get;
        }
        public abstract System.String ImageTagData
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.MapMode MapMode
        {
            get;
            set;
        }
        public abstract System.Int32 MaxCropAreas
        {
            get;
        }
        public abstract System.Int32 Quality
        {
            get;
            set;
        }
        public abstract System.Int32[] QualityList
        {
            get;
        }
        public abstract System.Int32 RemainingImagesEstimate
        {
            get;
        }
        public virtual System.Boolean CapAutoContrast
        {
            get { return false; }
        }
        public virtual System.Boolean CapContrast
        {
            get { return false; }
        }
        public virtual System.Int32 Contrast
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
        public virtual void BeginInsertion(System.Int32 timeout)
        {
        }
        public virtual void BeginRemoval(System.Int32 timeout)
        {
        }
        public virtual void ClearImage(Microsoft.PointOfService.CheckImageClear by)
        {
        }
        public virtual void DefineCropArea(System.Int32 cropAreaId, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
        {
        }
        public virtual void EndInsertion()
        {
        }
        public virtual void EndRemoval()
        {
        }
        public virtual void RetrieveImage(System.Int32 cropAreaId)
        {
        }
        public virtual void RetrieveMemory(Microsoft.PointOfService.CheckImageLocate by)
        {
        }
        public virtual void StoreImage(System.Int32 cropAreaId)
        {
        }
    }
}
