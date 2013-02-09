namespace Microsoft.PointOfService
{
    public abstract class MotionSensor : Microsoft.PointOfService.PosCommon
    {
        protected MotionSensor()
        {
        }
        public const System.String StatisticMotionEventCount = "MotionEventCount";
        public const System.Int32 StatusMotionPresent = 1;
        public const System.Int32 StatusMotionAbsent = 2;
        public abstract System.Boolean Motion { get; }
        public abstract System.Int32 Timeout { get; set;  }
        public virtual void WaitForMotion(System.Int32 timeout)
        {
        }
        
    }
}
