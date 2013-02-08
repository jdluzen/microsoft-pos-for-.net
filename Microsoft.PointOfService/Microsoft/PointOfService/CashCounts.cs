namespace Microsoft.PointOfService
{
    public struct CashCounts
    {
        public CashCounts(Microsoft.PointOfService.CashCount[] counts, System.Boolean discrepancy)
        {
        }
        public System.Boolean Discrepancy
        {
            get { return false; }
        }
        public Microsoft.PointOfService.CashCount[] Counts
        {
            get { return null; }
        }
        public System.Boolean Equals(Microsoft.PointOfService.CashCounts counts)
        {
            return false;
        }
        public override System.Boolean Equals(System.Object obj)
        {
            return false;
        }
        public static System.Boolean Equals(Microsoft.PointOfService.CashCounts a, Microsoft.PointOfService.CashCounts b)
        {
            return false;
        }
        public static System.Boolean operator ==(Microsoft.PointOfService.CashCounts a, System.Object b)
        {
            return false;
        }
        public static System.Boolean operator !=(Microsoft.PointOfService.CashCounts a, System.Object b)
        {
            return false;
        }
        public override System.Int32 GetHashCode()
        {
            return 0;
        }
    }
}
