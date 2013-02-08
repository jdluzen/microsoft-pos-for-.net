namespace Microsoft.PointOfService
{
    public class BillDispenser : Microsoft.PointOfService.PosCommon
    {
        protected BillDispenser()
        {
        }
        public const System.Int32 StatusEmpty = 11;
        public const System.Int32 StatusNearEmpty = 12;
        public const System.Int32 StatusEmptyOk = 13;
        public const System.Int32 StatusJam = 31;
        public const System.Int32 StatusJamOk = 32;
        public const System.Int32 StatusAsync = 91;
        public const System.Int32 ExtendedErrorOverDispense = 201;
        public System.Boolean CapDiscrepancy
        {
            get { return false; }
        }
        public System.Boolean CapEmptySensor
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
        public virtual void AdjustCashCounts(System.Collections.Generic.IEnumerable<Microsoft.PointOfService.CashCount> param_param_cashCounts)
        {
        }
        public virtual void DispenseCash(System.Collections.Generic.IEnumerable<Microsoft.PointOfService.CashCount> param_param_cashCounts)
        {
        }
        public virtual Microsoft.PointOfService.CashCounts ReadCashCounts()
        {
            return new Microsoft.PointOfService.CashCounts();
        }
    }
}
