namespace Microsoft.PointOfService
{
    public class PosPower : Microsoft.PointOfService.PosCommon
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
        public System.Boolean CapFanAlarm
        {
            get { return false; }
        }
        public System.Boolean CapHeatAlarm
        {
            get { return false; }
        }
        public System.Boolean CapQuickCharge
        {
            get { return false; }
        }
        public System.Boolean CapShutdownPos
        {
            get { return false; }
        }
        public Microsoft.PointOfService.UpsChargeStates CapUpsChargeState
        {
            get { return Microsoft.PointOfService.UpsChargeStates.Full; }
        }
        public System.Int32 EnforcedShutdownDelayTime
        {
            get { return 0; }
            set { }
        }
        public System.Int32 PowerFailDelayTime
        {
            get { return 0; }
        }
        public System.Boolean QuickChargeMode
        {
            get { return false; }
        }
        public System.Int32 QuickChargeTime
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.UpsChargeStates UpsChargeState
        {
            get { return Microsoft.PointOfService.UpsChargeStates.Full; }
        }
        public System.Int32 BatteryCapacityRemaining
        {
            get { return 0; }
        }
        public System.Int32 BatteryCriticallyLowThreshold
        {
            get { return 0; }
            set { }
        }
        public System.Int32 BatteryLowThreshold
        {
            get { return 0; }
            set { }
        }
        public System.Boolean CapBatteryCapacityRemaining
        {
            get { return false; }
        }
        public System.Boolean CapRestartPos
        {
            get { return false; }
        }
        public System.Boolean CapStandbyPos
        {
            get { return false; }
        }
        public System.Boolean CapSuspendPos
        {
            get { return false; }
        }
        public System.Boolean CapVariableBatteryCriticallyLowThreshold
        {
            get { return false; }
        }
        public System.Boolean CapVariableBatteryLowThreshold
        {
            get { return false; }
        }
        public Microsoft.PointOfService.PowerSource PowerSource
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
