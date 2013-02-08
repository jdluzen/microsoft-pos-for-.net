namespace Microsoft.PointOfService
{
    public class Belt : Microsoft.PointOfService.PosCommon
    {
        protected Belt()
        {
        }
        public const System.Int32 StatusAutoStop = 11;
        public const System.Int32 StatusEmergencyStop = 12;
        public const System.Int32 StatusSafetyStop = 13;
        public const System.Int32 StatusTimeoutStop = 14;
        public const System.Int32 StatusMotorOverheating = 15;
        public const System.Int32 StatusMotorFuseDefect = 16;
        public const System.Int32 StatusLightBarrierBackwardInterrupted = 17;
        public const System.Int32 StatusLightBarrierBackwardOk = 18;
        public const System.Int32 StatusLightBarrierForwardInterrupted = 19;
        public const System.Int32 StatusLightBarrierForwardOk = 20;
        public const System.Int32 StatusSecurityFlapBackwardOpened = 21;
        public const System.Int32 StatusSecurityFlapBackwardClosed = 22;
        public const System.Int32 StatusSecurityFlapForwardOpened = 23;
        public const System.Int32 StatusSecurityFlapForwardClosed = 24;
        public System.Boolean AutoStopBackward
        {
            get { return false; }
            set { }
        }
        public System.Int32 AutoStopBackwardDelayTime
        {
            get { return 0; }
            set { }
        }
        public System.Int32 AutoStopBackwardItemCount
        {
            get { return 0; }
        }
        public System.Boolean AutoStopForward
        {
            get { return false; }
            set { }
        }
        public System.Int32 AutoStopForwardDelayTime
        {
            get { return 0; }
            set { }
        }
        public System.Int32 AutoStopForwardItemCount
        {
            get { return 0; }
        }
        public System.Boolean CapAutoStopBackward
        {
            get { return false; }
        }
        public System.Boolean CapAutoStopBackwardItemCount
        {
            get { return false; }
        }
        public System.Boolean CapAutoStopForward
        {
            get { return false; }
        }
        public System.Boolean CapAutoStopForwardItemCount
        {
            get { return false; }
        }
        public System.Boolean CapLightBarrierBackward
        {
            get { return false; }
        }
        public System.Boolean CapLightBarrierForward
        {
            get { return false; }
        }
        public System.Boolean CapMoveBackward
        {
            get { return false; }
        }
        public System.Boolean CapSecurityFlapBackward
        {
            get { return false; }
        }
        public System.Boolean CapSecurityFlapForward
        {
            get { return false; }
        }
        public System.Int32 CapSpeedStepsBackward
        {
            get { return 0; }
        }
        public System.Int32 CapSpeedStepsForward
        {
            get { return 0; }
        }
        public System.Boolean LightBarrierBackwardInterrupted
        {
            get { return false; }
        }
        public System.Boolean LightBarrierForwardInterrupted
        {
            get { return false; }
        }
        public Microsoft.PointOfService.BeltMotionStatus MotionStatus
        {
            get { return Microsoft.PointOfService.BeltMotionStatus.Forward; }
        }
        public System.Boolean SecurityFlapBackwardOpened
        {
            get { return false; }
        }
        public System.Boolean SecurityFlapForwardOpened
        {
            get { return false; }
        }
        public virtual void AdjustItemCount(Microsoft.PointOfService.BeltDirection direction, System.Int32 count)
        {
        }
        public virtual void MoveBackward(System.Int32 speed)
        {
        }
        public virtual void MoveForward(System.Int32 speed)
        {
        }
        public virtual void ResetBelt()
        {
        }
        public virtual void ResetItemCount(Microsoft.PointOfService.BeltDirection direction)
        {
        }
        public virtual void StopBelt()
        {
        }
    }
}
