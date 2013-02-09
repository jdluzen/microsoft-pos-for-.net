namespace Microsoft.PointOfService
{
    public struct CashCount
    {
        public CashCount(Microsoft.PointOfService.CashCountType type, System.Int32 nominalValue, System.Int32 count)
        {
        }
        
        public System.Int32 NominalValue { get { return 0; } }
        public System.Int32 Count { get { return 0; } }
        public Microsoft.PointOfService.CashCountType Type { get { return Microsoft.PointOfService.CashCountType.Coin; } }
        public System.Boolean Equals(Microsoft.PointOfService.CashCount count)
        {
            return false;
        }
        
        public override System.Boolean Equals(System.Object obj)
        {
            return false;
        }
        
        public static System.Boolean Equals(Microsoft.PointOfService.CashCount a, Microsoft.PointOfService.CashCount b)
        {
            return false;
        }
        
        public static System.Boolean operator ==(Microsoft.PointOfService.CashCount a, System.Object b)
        {
            return false;
        }
        
        public static System.Boolean operator !=(Microsoft.PointOfService.CashCount a, System.Object b)
        {
            return false;
        }
        
        public override System.Int32 GetHashCode()
        {
            return 0;
        }
        
    }
}
