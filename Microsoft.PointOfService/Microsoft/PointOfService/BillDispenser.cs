namespace Microsoft.PointOfService
{
    public abstract class BillDispenser : Microsoft.PointOfService.PosCommon
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
        public abstract System.Boolean CapDiscrepancy
        {
            get;
        }
        public abstract System.Boolean CapEmptySensor
        {
            get;
        }
        public abstract System.Boolean CapJamSensor
        {
            get;
        }
        public abstract System.Boolean CapNearEmptySensor
        {
            get;
        }
        public abstract System.Boolean AsyncMode
        {
            get;
            set;
        }
        public abstract System.Int32 AsyncResultCode
        {
            get;
        }
        public abstract System.Int32 AsyncResultCodeExtended
        {
            get;
        }
        public abstract Microsoft.PointOfService.CashUnits CurrencyCashList
        {
            get;
        }
        public abstract System.String CurrencyCode
        {
            get;
            set;
        }
        public abstract System.String[] CurrencyCodeList
        {
            get;
        }
        public abstract System.Int32 CurrentExit
        {
            get;
            set;
        }
        public abstract System.Int32 DeviceExits
        {
            get;
        }
        public abstract Microsoft.PointOfService.CashChangerStatus DeviceStatus
        {
            get;
        }
        public abstract Microsoft.PointOfService.CashUnits ExitCashList
        {
            get;
        }
        public virtual void AdjustCashCounts(System.Collections.Generic.IEnumerable<Microsoft.PointOfService.CashCount> cashCounts)
        {
        }
        public virtual void DispenseCash(System.Collections.Generic.IEnumerable<Microsoft.PointOfService.CashCount> cashCounts)
        {
        }
        public virtual Microsoft.PointOfService.CashCounts ReadCashCounts()
        {
            return new Microsoft.PointOfService.CashCounts();
        }
    }
}
