namespace Microsoft.PointOfService
{
    public struct CashCount
    {
        public CashCount(Microsoft.PointOfService.CashCountType param_param_type, System.Int32 param_param_nominalValue, System.Int32 param_param_count)
        {
        }
        public System.Int32 NominalValue
        {
            get { return 0; }
        }
        public System.Int32 Count
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.CashCountType Type
        {
            get { return Microsoft.PointOfService.CashCountType.Coin; }
        }
        public System.Boolean Equals(Microsoft.PointOfService.CashCount param_param_count)
        {
            return false;
        }
        public override System.Boolean Equals(System.Object param_param_obj)
        {
            return false;
        }
        public static System.Boolean Equals(Microsoft.PointOfService.CashCount param_param_a, Microsoft.PointOfService.CashCount param_param_b)
        {
            return false;
        }
        public static System.Boolean operator ==(Microsoft.PointOfService.CashCount param_param_a, System.Object param_param_b)
        {
            return false;
        }
        public static System.Boolean operator !=(Microsoft.PointOfService.CashCount param_param_a, System.Object param_param_b)
        {
            return false;
        }
        public override System.Int32 GetHashCode()
        {
            return 0;
        }
    }
}
