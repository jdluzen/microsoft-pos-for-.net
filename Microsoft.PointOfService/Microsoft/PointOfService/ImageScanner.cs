namespace Microsoft.PointOfService
{
    public class ImageScanner : Microsoft.PointOfService.PosCommon
    {
        protected ImageScanner()
        {
        }
        public const System.String StatisticGoodReadCount = "GoodReadCount";
        public const System.String StatisticNoReadCount = "NoReadCount";
        public const System.String StatisticSessionCount = "SessionCount";
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
        public System.Boolean CapAim
        {
            get { return false; }
        }
        public System.Boolean CapDecodeData
        {
            get { return false; }
        }
        public System.Boolean CapHostTriggered
        {
            get { return false; }
        }
        public System.Boolean CapIlluminate
        {
            get { return false; }
        }
        public System.Boolean CapImageData
        {
            get { return false; }
        }
        public System.Boolean CapImageQuality
        {
            get { return false; }
        }
        public System.Boolean CapVideoData
        {
            get { return false; }
        }
        public System.Boolean AimMode
        {
            get { return false; }
            set { }
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Drawing.Bitmap> FrameData
        {
            get { return null; }
        }
        public Microsoft.PointOfService.FrameType FrameType
        {
            get { return Microsoft.PointOfService.FrameType.Still; }
        }
        public System.Boolean IlluminateMode
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.ImageMode ImageMode
        {
            get { return Microsoft.PointOfService.ImageMode.DecodeOnly; }
            set { }
        }
        public Microsoft.PointOfService.ImageQuality ImageQuality
        {
            get { return Microsoft.PointOfService.ImageQuality.Low; }
            set { }
        }
        public System.Int32 VideoCount
        {
            get { return 0; }
            set { }
        }
        public System.Int32 VideoRate
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
        public virtual void StartSession()
        {
        }
        public virtual void StopSession()
        {
        }
    }
}
