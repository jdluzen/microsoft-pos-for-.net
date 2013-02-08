namespace Microsoft.PointOfService
{
    public abstract class Gate : Microsoft.PointOfService.PosCommon
    {
        protected Gate()
        {
        }
        public const System.Int32 StatusClosed = 11;
        public const System.Int32 StatusOpen = 12;
        public const System.Int32 StatusBlocked = 13;
        public const System.Int32 StatusMalfunction = 14;
        public abstract System.Boolean CapGateStatus
        {
            get;
        }
        public abstract Microsoft.PointOfService.GateStatus GateStatus
        {
            get;
        }
        public virtual void OpenGate()
        {
        }
        public virtual void WaitForGateClose(System.Int32 timeout)
        {
        }
    }
}
