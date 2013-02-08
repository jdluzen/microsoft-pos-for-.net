namespace Microsoft.PointOfService
{
    public struct FiscalDataItem
    {
        public FiscalDataItem(System.String data, System.Int32 itemOption)
        {
        }
        public System.String Data
        {
            get { return null; }
        }
        public System.Int32 ItemOption
        {
            get { return 0; }
        }
        public System.Boolean Equals(Microsoft.PointOfService.FiscalDataItem fiscalDataItem)
        {
            return false;
        }
        public override System.Boolean Equals(System.Object obj)
        {
            return false;
        }
        public static System.Boolean Equals(Microsoft.PointOfService.FiscalDataItem a, Microsoft.PointOfService.FiscalDataItem b)
        {
            return false;
        }
        public static System.Boolean operator ==(Microsoft.PointOfService.FiscalDataItem a, System.Object b)
        {
            return false;
        }
        public static System.Boolean operator !=(Microsoft.PointOfService.FiscalDataItem a, System.Object b)
        {
            return false;
        }
        public override System.Int32 GetHashCode()
        {
            return 0;
        }
    }
}
