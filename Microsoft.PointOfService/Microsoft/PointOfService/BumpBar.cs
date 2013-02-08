namespace Microsoft.PointOfService
{
    public class BumpBar : Microsoft.PointOfService.PosCommon
    {
        protected BumpBar()
        {
        }
        public const System.Int32 DataEventKey = 1;
        public const System.String StatisticBumpCount = "BumpCount";
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
        }
        public System.Int32 OutputId
        {
            get { return 0; }
        }
        public System.Boolean AsyncMode
        {
            get { return false; }
            set { }
        }
        public System.Int32 AutoToneDuration
        {
            get { return 0; }
            set { }
        }
        public System.Int32 AutoToneFrequency
        {
            get { return 0; }
            set { }
        }
        public System.Int32 BumpBarDataCount
        {
            get { return 0; }
        }
        public System.Boolean CapTone
        {
            get { return false; }
        }
        public Microsoft.PointOfService.DeviceUnits CurrentUnitId
        {
            get { return Microsoft.PointOfService.DeviceUnits.Unit1; }
            set { }
        }
        public System.String ErrorString
        {
            get { return null; }
        }
        public Microsoft.PointOfService.DeviceUnits ErrorUnits
        {
            get { return Microsoft.PointOfService.DeviceUnits.Unit1; }
        }
        public System.String EventString
        {
            get { return null; }
        }
        public Microsoft.PointOfService.DeviceUnits EventUnitId
        {
            get { return Microsoft.PointOfService.DeviceUnits.Unit1; }
        }
        public Microsoft.PointOfService.DeviceUnits EventUnits
        {
            get { return Microsoft.PointOfService.DeviceUnits.Unit1; }
        }
        public System.Int32 Keys
        {
            get { return 0; }
        }
        public System.Int32 Timeout
        {
            get { return 0; }
            set { }
        }
        public Microsoft.PointOfService.DeviceUnits UnitsOnline
        {
            get { return Microsoft.PointOfService.DeviceUnits.Unit1; }
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
        #pragma warning disable 67
        public event Microsoft.PointOfService.OutputCompleteEventHandler OutputCompleteEvent
        {
            add { }
            remove { }
        }
        public virtual void ClearInput()
        {
        }
        public virtual void ClearOutput()
        {
        }
        public virtual void BumpBarSound(Microsoft.PointOfService.DeviceUnits param_param_units, System.Int32 param_param_frequency, System.Int32 param_param_duration, System.Int32 param_param_numberOfCycles, System.Int32 param_param_interSoundWait)
        {
        }
        public virtual void SetKeyTranslation(Microsoft.PointOfService.DeviceUnits param_param_units, System.Int32 param_param_scanCode, System.Int32 param_param_logicalKey)
        {
        }
    }
}
