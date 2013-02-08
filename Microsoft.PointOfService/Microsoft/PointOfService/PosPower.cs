namespace Microsoft.PointOfService
{
    public abstract class PosPower : Microsoft.PointOfService.PosCommon
    {
        protected PosPower()
        {
        }
        public const System.Int32 StatusUpsFull = 11;
        public const System.Int32 StatusUpsWarning = 12;
        public const System.Int32 StatusUpsLow = 13;
        public const System.Int32 StatusUpsCritical = 14;
        public const System.Int32 StatusFanStopped = 15;
        public const System.Int32 StatusFanRunning = 16;
        public const System.Int32 StatusTemperatureHigh = 17;
        public const System.Int32 StatusTemperatureOK = 18;
        public const System.Int32 StatusShutDown = 19;
        public const System.Int32 StatusBatteryLow = 20;
        public const System.Int32 StatusBatteryCritical = 21;
        public const System.Int32 StatusBatteryCapacityRemaining = 22;
        public const System.Int32 StatusRestart = 23;
        public const System.Int32 StatusStandby = 24;
        public const System.Int32 StatusUserStandby = 25;
        public const System.Int32 StatusSuspend = 26;
        public const System.Int32 StatusUserSuspend = 27;
        public const System.Int32 StatusPowerSource = 28;
        public abstract System.Boolean CapFanAlarm
        {
            get;
        }
        public abstract System.Boolean CapHeatAlarm
        {
            get;
        }
        public abstract System.Boolean CapQuickCharge
        {
            get;
        }
        public abstract System.Boolean CapShutdownPos
        {
            get;
        }
        public abstract Microsoft.PointOfService.UpsChargeStates CapUpsChargeState
        {
            get;
        }
        public abstract System.Int32 EnforcedShutdownDelayTime
        {
            get;
            set;
        }
        public abstract System.Int32 PowerFailDelayTime
        {
            get;
        }
        public abstract System.Boolean QuickChargeMode
        {
            get;
        }
        public abstract System.Int32 QuickChargeTime
        {
            get;
        }
        public abstract Microsoft.PointOfService.UpsChargeStates UpsChargeState
        {
            get;
        }
        public virtual System.Int32 BatteryCapacityRemaining
        {
            get { return 0; }
        }
        public virtual System.Int32 BatteryCriticallyLowThreshold
        {
            get { return 0; }
            set { }
        }
        public virtual System.Int32 BatteryLowThreshold
        {
            get { return 0; }
            set { }
        }
        public virtual System.Boolean CapBatteryCapacityRemaining
        {
            get { return false; }
        }
        public virtual System.Boolean CapRestartPos
        {
            get { return false; }
        }
        public virtual System.Boolean CapStandbyPos
        {
            get { return false; }
        }
        public virtual System.Boolean CapSuspendPos
        {
            get { return false; }
        }
        public virtual System.Boolean CapVariableBatteryCriticallyLowThreshold
        {
            get { return false; }
        }
        public virtual System.Boolean CapVariableBatteryLowThreshold
        {
            get { return false; }
        }
        public virtual Microsoft.PointOfService.PowerSource PowerSource
        {
            get { return Microsoft.PointOfService.PowerSource.NotAvailable; }
        }
        public virtual void ShutdownPos()
        {
        }
        public virtual void RestartPos()
        {
        }
        public virtual void StandbyPos(Microsoft.PointOfService.SystemStateChangeReason reason)
        {
        }
        public virtual void SuspendPos(Microsoft.PointOfService.SystemStateChangeReason reason)
        {
        }
    }
}
