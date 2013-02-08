namespace Microsoft.PointOfService
{
    public class ServiceObjectAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
    {
        public ServiceObjectAttribute(System.String param_param_type, System.String param_param_name, System.String param_param_description, System.Int32 param_param_uposVersionMajor, System.Int32 param_param_uposVersionMinor)
        {
        }
        protected ServiceObjectAttribute()
        {
        }
        public System.String Type
        {
            get { return null; }
        }
        public System.String Name
        {
            get { return null; }
        }
        public System.String Description
        {
            get { return null; }
        }
        public System.Version UposVersion
        {
            get { return null; }
        }
        public System.Int32 UposVersionMajor
        {
            get { return 0; }
        }
        public System.Int32 UposVersionMinor
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.DeviceCompatibilities Compatibility
        {
            get { return Microsoft.PointOfService.DeviceCompatibilities.Opos; }
        }
    }
}
