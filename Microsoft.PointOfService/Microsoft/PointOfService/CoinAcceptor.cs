namespace Microsoft.PointOfService
{
    public class CoinAcceptor : Microsoft.PointOfService.PosCommon
    {
        protected CoinAcceptor()
        {
        }
        public const System.Int32 StatusFull = 21;
        public const System.Int32 StatusNearFull = 22;
        public const System.Int32 StatusFullOk = 23;
        public const System.Int32 StatusJam = 31;
        public const System.Int32 StatusJamOk = 32;
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapDiscrepancy
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
        public System.String CurrencyCode
        {
            get { return null; }
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
        public Microsoft.PointOfService.DepositStatus DepositStatus
        {
            get { return Microsoft.PointOfService.DepositStatus.Start; }
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
        #pragma warning disable 67
        public event Microsoft.PointOfService.DataEventHandler DataEvent
        {
            add { }
            remove { }
        }
        public virtual void ClearInput()
        {
        }
        public virtual void AdjustCashCounts(System.Collections.Generic.IEnumerable<Microsoft.PointOfService.CashCount> param_param_cashCounts)
        {
        }
        public virtual void BeginDeposit()
        {
        }
        public virtual void EndDeposit(Microsoft.PointOfService.EndDepositAction param_param_success)
        {
        }
        public virtual void FixDeposit()
        {
        }
        public virtual void PauseDeposit(Microsoft.PointOfService.CashDepositPause param_param_control)
        {
        }
        public virtual Microsoft.PointOfService.CashCounts ReadCashCounts()
        {
            return new Microsoft.PointOfService.CashCounts();
        }
    }
}
