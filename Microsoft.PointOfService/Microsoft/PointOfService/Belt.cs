namespace Microsoft.PointOfService
{
    public abstract class Belt : Microsoft.PointOfService.PosCommon
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
        public abstract System.Boolean AutoStopBackward
        {
            get;
            set;
        }
        public abstract System.Int32 AutoStopBackwardDelayTime
        {
            get;
            set;
        }
        public abstract System.Int32 AutoStopBackwardItemCount
        {
            get;
        }
        public abstract System.Boolean AutoStopForward
        {
            get;
            set;
        }
        public abstract System.Int32 AutoStopForwardDelayTime
        {
            get;
            set;
        }
        public abstract System.Int32 AutoStopForwardItemCount
        {
            get;
        }
        public abstract System.Boolean CapAutoStopBackward
        {
            get;
        }
        public abstract System.Boolean CapAutoStopBackwardItemCount
        {
            get;
        }
        public abstract System.Boolean CapAutoStopForward
        {
            get;
        }
        public abstract System.Boolean CapAutoStopForwardItemCount
        {
            get;
        }
        public abstract System.Boolean CapLightBarrierBackward
        {
            get;
        }
        public abstract System.Boolean CapLightBarrierForward
        {
            get;
        }
        public abstract System.Boolean CapMoveBackward
        {
            get;
        }
        public abstract System.Boolean CapSecurityFlapBackward
        {
            get;
        }
        public abstract System.Boolean CapSecurityFlapForward
        {
            get;
        }
        public abstract System.Int32 CapSpeedStepsBackward
        {
            get;
        }
        public abstract System.Int32 CapSpeedStepsForward
        {
            get;
        }
        public abstract System.Boolean LightBarrierBackwardInterrupted
        {
            get;
        }
        public abstract System.Boolean LightBarrierForwardInterrupted
        {
            get;
        }
        public abstract Microsoft.PointOfService.BeltMotionStatus MotionStatus
        {
            get;
        }
        public abstract System.Boolean SecurityFlapBackwardOpened
        {
            get;
        }
        public abstract System.Boolean SecurityFlapForwardOpened
        {
            get;
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
