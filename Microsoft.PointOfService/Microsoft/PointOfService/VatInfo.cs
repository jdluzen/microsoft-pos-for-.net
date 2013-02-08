namespace Microsoft.PointOfService
{
    public struct VatInfo
    {
        public VatInfo(System.Int32 id, System.Decimal amount)
        {
        }
        public System.Int32 Id
        {
            get { return 0; }
        }
        public System.Decimal Amount
        {
            get { return new System.Decimal(); }
        }
        public System.Boolean Equals(Microsoft.PointOfService.VatInfo vatInfo)
        {
            return false;
        }
        public override System.Boolean Equals(System.Object obj)
        {
            return false;
        }
        public static System.Boolean Equals(Microsoft.PointOfService.VatInfo a, Microsoft.PointOfService.VatInfo b)
        {
            return false;
        }
        public static System.Boolean operator ==(Microsoft.PointOfService.VatInfo a, System.Object b)
        {
            return false;
        }
        public static System.Boolean operator !=(Microsoft.PointOfService.VatInfo a, System.Object b)
        {
            return false;
        }
        public override System.Int32 GetHashCode()
        {
            return 0;
        }
    }
}
