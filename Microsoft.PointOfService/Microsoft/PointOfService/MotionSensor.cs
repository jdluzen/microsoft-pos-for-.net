namespace Microsoft.PointOfService
{
    public class MotionSensor : Microsoft.PointOfService.PosCommon
    {
        protected MotionSensor()
        {
        }
        public const System.String StatisticMotionEventCount = "MotionEventCount";
        public const System.Int32 StatusMotionPresent = 1;
        public const System.Int32 StatusMotionAbsent = 2;
        public System.Boolean Motion
        {
            get { return false; }
        }
        public System.Int32 Timeout
        {
            get { return 0; }
            set { }
        }
        public virtual void WaitForMotion(System.Int32 timeout)
        {
        }
    }
}
