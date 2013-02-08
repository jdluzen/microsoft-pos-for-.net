namespace Microsoft.PointOfService
{
    public abstract class ImageScanner : Microsoft.PointOfService.PosCommon
    {
        protected ImageScanner()
        {
        }
        public const System.String StatisticGoodReadCount = "GoodReadCount";
        public const System.String StatisticNoReadCount = "NoReadCount";
        public const System.String StatisticSessionCount = "SessionCount";
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
        public abstract System.Boolean CapAim
        {
            get;
        }
        public abstract System.Boolean CapDecodeData
        {
            get;
        }
        public abstract System.Boolean CapHostTriggered
        {
            get;
        }
        public abstract System.Boolean CapIlluminate
        {
            get;
        }
        public abstract System.Boolean CapImageData
        {
            get;
        }
        public abstract System.Boolean CapImageQuality
        {
            get;
        }
        public abstract System.Boolean CapVideoData
        {
            get;
        }
        public abstract System.Boolean AimMode
        {
            get;
            set;
        }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Drawing.Bitmap> FrameData
        {
            get;
        }
        public abstract Microsoft.PointOfService.FrameType FrameType
        {
            get;
        }
        public abstract System.Boolean IlluminateMode
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.ImageMode ImageMode
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.ImageQuality ImageQuality
        {
            get;
            set;
        }
        public abstract System.Int32 VideoCount
        {
            get;
            set;
        }
        public abstract System.Int32 VideoRate
        {
            get;
            set;
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
        public virtual void StartSession()
        {
        }
        public virtual void StopSession()
        {
        }
    }
}
