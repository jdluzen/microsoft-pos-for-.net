namespace Microsoft.PointOfService
{
    public class CoinDispenser : Microsoft.PointOfService.PosCommon
    {
        protected CoinDispenser()
        {
        }
        public const System.Int32 StatusOk = 1;
        public const System.Int32 StatusEmpty = 2;
        public const System.Int32 StatusNearEmpty = 3;
        public const System.Int32 StatusJam = 4;
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
        public Microsoft.PointOfService.CoinDispenserStatus DispenserStatus
        {
            get { return Microsoft.PointOfService.CoinDispenserStatus.OK; }
        }
        public virtual void AdjustCashCounts(System.Collections.Generic.IEnumerable<Microsoft.PointOfService.CashCount> param_param_cashCounts)
        {
        }
        public virtual void DispenseChange(System.Int32 param_param_amount)
        {
        }
        public virtual Microsoft.PointOfService.CashCounts ReadCashCounts()
        {
            return new Microsoft.PointOfService.CashCounts();
        }
    }
}
