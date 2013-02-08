namespace Microsoft.PointOfService
{
    public class CashChanger : Microsoft.PointOfService.PosCommon
    {
        protected CashChanger()
        {
        }
        public const System.Int32 StatusOK = 0;
        public const System.Int32 StatusEmpty = 11;
        public const System.Int32 StatusNearEmpty = 12;
        public const System.Int32 StatusEmptyOK = 13;
        public const System.Int32 StatusFull = 21;
        public const System.Int32 StatusNearFull = 22;
        public const System.Int32 StatusFullOK = 23;
        public const System.Int32 StatusJam = 31;
        public const System.Int32 StatusJamOK = 32;
        public const System.Int32 StatusAsync = 91;
        public const System.Int32 ExtendedErrorOverDispense = 201;
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapDeposit
        {
            get { return false; }
        }
        public System.Boolean CapDepositDataEvent
        {
            get { return false; }
        }
        public System.Boolean CapDiscrepancy
        {
            get { return false; }
        }
        public System.Boolean CapEmptySensor
        {
            get { return false; }
        }
        public System.Boolean CapFullSensor
        {
            get { return false; }
        }
        public System.Boolean CapJamSensor
        {
            get { return false; }
        }
        public System.Boolean CapNearEmptySensor
        {
            get { return false; }
        }
        public System.Boolean CapNearFullSensor
        {
            get { return false; }
        }
        public System.Boolean CapPauseDeposit
        {
            get { return false; }
        }
        public System.Boolean CapRealTimeData
        {
            get { return false; }
        }
        public System.Boolean CapRepayDeposit
        {
            get { return false; }
        }
        public System.Boolean AsyncMode
        {
            get { return false; }
            set { }
        }
        public System.Int32 AsyncResultCode
        {
            get { return 0; }
        }
        public System.Int32 AsyncResultCodeExtended
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.CashUnits CurrencyCashList
        {
            get { return new Microsoft.PointOfService.CashUnits(); }
        }
        public System.String CurrencyCode
        {
            get { return null; }
            set { }
        }
        public System.String[] CurrencyCodeList
        {
            get { return null; }
        }
        public System.Int32 CurrentExit
        {
            get { return 0; }
            set { }
        }
        public System.Int32 CurrentService
        {
            get { return 0; }
            set { }
        }
        public System.Int32 DepositAmount
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.CashUnits DepositCashList
        {
            get { return new Microsoft.PointOfService.CashUnits(); }
        }
        public System.String[] DepositCodeList
        {
            get { return null; }
        }
        public Microsoft.PointOfService.CashCount[] DepositCounts
        {
            get { return null; }
        }
        public Microsoft.PointOfService.CashDepositStatus DepositStatus
        {
            get { return Microsoft.PointOfService.CashDepositStatus.Start; }
        }
        public System.Int32 DeviceExits
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.CashChangerStatus DeviceStatus
        {
            get { return Microsoft.PointOfService.CashChangerStatus.OK; }
        }
        public Microsoft.PointOfService.CashUnits ExitCashList
        {
            get { return new Microsoft.PointOfService.CashUnits(); }
        }
        public Microsoft.PointOfService.CashChangerFullStatus FullStatus
        {
            get { return Microsoft.PointOfService.CashChangerFullStatus.OK; }
        }
        public System.Boolean RealTimeDataEnabled
        {
            get { return false; }
            set { }
        }
        public System.Int32 ServiceCount
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.ServiceIndex ServiceIndex
        {
            get { return new Microsoft.PointOfService.ServiceIndex(); }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DataEventHandler DataEvent
        {
            add { }
            remove { }
        }
        public virtual void ClearInput()
        {
        }
        public virtual void AdjustCashCounts(System.Collections.Generic.IEnumerable<Microsoft.PointOfService.CashCount> cashCounts)
        {
        }
        public virtual void BeginDeposit()
        {
        }
        public virtual void DispenseCash(Microsoft.PointOfService.CashCount[] cashCounts)
        {
        }
        public virtual void DispenseChange(System.Int32 amount)
        {
        }
        public virtual void EndDeposit(Microsoft.PointOfService.CashDepositAction successAction)
        {
        }
        public virtual void FixDeposit()
        {
        }
        public virtual void PauseDeposit(Microsoft.PointOfService.CashDepositPause pauseAction)
        {
        }
        public virtual Microsoft.PointOfService.CashCounts ReadCashCounts()
        {
            return new Microsoft.PointOfService.CashCounts();
        }
    }
}
