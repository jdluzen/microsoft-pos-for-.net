namespace Microsoft.PointOfService
{
    public struct VatInfo
    {
        public VatInfo(System.Int32 param_param_id, System.Decimal param_param_amount)
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
        public System.Boolean Equals(Microsoft.PointOfService.VatInfo param_param_vatInfo)
        {
            return false;
        }
        public override System.Boolean Equals(System.Object param_param_obj)
        {
            return false;
        }
        public static System.Boolean Equals(Microsoft.PointOfService.VatInfo param_param_a, Microsoft.PointOfService.VatInfo param_param_b)
        {
            return false;
        }
        public static System.Boolean operator ==(Microsoft.PointOfService.VatInfo param_param_a, System.Object param_param_b)
        {
            return false;
        }
        public static System.Boolean operator !=(Microsoft.PointOfService.VatInfo param_param_a, System.Object param_param_b)
        {
            return false;
        }
        public override System.Int32 GetHashCode()
        {
            return 0;
        }
    }
}
