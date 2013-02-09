namespace Microsoft.PointOfService
{
    public struct CashUnits
    {
        public CashUnits(System.Int32[] coins, System.Int32[] bills)
        {
        }
        
        public System.Int32[] Coins { get { return null; } }
        public System.Int32[] Bills { get { return null; } }
        public System.Boolean Equals(Microsoft.PointOfService.CashUnits units)
        {
            return false;
        }
        
        public override System.Boolean Equals(System.Object obj)
        {
            return false;
        }
        
        public static System.Boolean Equals(Microsoft.PointOfService.CashUnits a, Microsoft.PointOfService.CashUnits b)
        {
            return false;
        }
        
        public static System.Boolean operator ==(Microsoft.PointOfService.CashUnits a, System.Object b)
        {
            return false;
        }
        
        public static System.Boolean operator !=(Microsoft.PointOfService.CashUnits a, System.Object b)
        {
            return false;
        }
        
        public override System.Int32 GetHashCode()
        {
            return 0;
        }
        
    }
}
