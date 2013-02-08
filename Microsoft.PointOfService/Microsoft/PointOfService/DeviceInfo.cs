namespace Microsoft.PointOfService
{
    public class DeviceInfo
    {
        protected DeviceInfo()
        {
        }
        public System.String ServiceObjectName
        {
            get { return null; }
        }
        public System.String Description
        {
            get { return null; }
        }
        public System.String Type
        {
            get { return null; }
        }
        public Microsoft.PointOfService.DeviceCompatibilities Compatibility
        {
            get { return Microsoft.PointOfService.DeviceCompatibilities.Opos; }
        }
        public System.Version UposVersion
        {
            get { return null; }
        }
        public System.String HardwareDescription
        {
            get { return null; }
        }
        public System.String HardwarePath
        {
            get { return null; }
        }
        public System.String HardwareId
        {
            get { return null; }
        }
        public System.String[] LogicalNames
        {
            get { return null; }
        }
        public System.String ManufacturerName
        {
            get { return null; }
        }
        public System.Version ServiceObjectVersion
        {
            get { return null; }
        }
        public System.Boolean IsDefault
        {
            get { return false; }
        }
        public System.Boolean IsDeviceInfoOf(Microsoft.PointOfService.PosCommon param_param_serviceObject)
        {
            return false;
        }
        public override System.String ToString()
        {
            return null;
        }
    }
}
