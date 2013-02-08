namespace Microsoft.PointOfService
{
    public abstract class CoinDispenser : Microsoft.PointOfService.PosCommon
    {
        protected CoinDispenser()
        {
        }
        public const System.Int32 StatusOk = 1;
        public const System.Int32 StatusEmpty = 2;
        public const System.Int32 StatusNearEmpty = 3;
        public const System.Int32 StatusJam = 4;
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
        public abstract Microsoft.PointOfService.CoinDispenserStatus DispenserStatus
        {
            get;
        }
        public virtual void AdjustCashCounts(System.Collections.Generic.IEnumerable<Microsoft.PointOfService.CashCount> cashCounts)
        {
        }
        public virtual void DispenseChange(System.Int32 amount)
        {
        }
        public virtual Microsoft.PointOfService.CashCounts ReadCashCounts()
        {
            return new Microsoft.PointOfService.CashCounts();
        }
    }
}
