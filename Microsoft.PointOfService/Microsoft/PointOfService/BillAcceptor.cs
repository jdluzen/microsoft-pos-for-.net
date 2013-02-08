namespace Microsoft.PointOfService
{
    public abstract class BillAcceptor : Microsoft.PointOfService.PosCommon
    {
        protected BillAcceptor()
        {
        }
        public const System.Int32 StatusFull = 21;
        public const System.Int32 StatusNearFull = 22;
        public const System.Int32 StatusFullOk = 23;
        public const System.Int32 StatusJam = 31;
        public const System.Int32 StatusJamOk = 32;
        public abstract System.Int32 DataCount
        {
            get;
        }
        public abstract System.Boolean DataEventEnabled
        {
            get;
            set;
        }
        public abstract System.Boolean CapDiscrepancy
        {
            get;
        }
        public abstract System.Boolean CapFullSensor
        {
            get;
        }
        public abstract System.Boolean CapJamSensor
        {
            get;
        }
        public abstract System.Boolean CapNearFullSensor
        {
            get;
        }
        public abstract System.Boolean CapPauseDeposit
        {
            get;
        }
        public abstract System.Boolean CapRealTimeData
        {
            get;
        }
        public abstract System.String CurrencyCode
        {
            get;
            set;
        }
        public abstract System.Int32 DepositAmount
        {
            get;
        }
        public abstract Microsoft.PointOfService.CashUnits DepositCashList
        {
            get;
        }
        public abstract System.String[] DepositCodeList
        {
            get;
        }
        public abstract Microsoft.PointOfService.CashCount[] DepositCounts
        {
            get;
        }
        public abstract Microsoft.PointOfService.DepositStatus DepositStatus
        {
            get;
        }
        public abstract Microsoft.PointOfService.CashChangerFullStatus FullStatus
        {
            get;
        }
        public abstract System.Boolean RealTimeDataEnabled
        {
            get;
            set;
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
        public virtual void EndDeposit(Microsoft.PointOfService.EndDepositAction success)
        {
        }
        public virtual void FixDeposit()
        {
        }
        public virtual void PauseDeposit(Microsoft.PointOfService.CashDepositPause control)
        {
        }
        public virtual Microsoft.PointOfService.CashCounts ReadCashCounts()
        {
            return new Microsoft.PointOfService.CashCounts();
        }
    }
}
