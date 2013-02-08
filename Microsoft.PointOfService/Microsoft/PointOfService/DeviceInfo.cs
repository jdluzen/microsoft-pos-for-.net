namespace Microsoft.PointOfService
{
    public abstract class DeviceInfo
    {
        protected DeviceInfo()
        {
        }
        public abstract System.String ServiceObjectName
        {
            get;
        }
        public abstract System.String Description
        {
            get;
        }
        public abstract System.String Type
        {
            get;
        }
        public abstract Microsoft.PointOfService.DeviceCompatibilities Compatibility
        {
            get;
        }
        public abstract System.Version UposVersion
        {
            get;
        }
        public abstract System.String HardwareDescription
        {
            get;
        }
        public abstract System.String HardwarePath
        {
            get;
        }
        public abstract System.String HardwareId
        {
            get;
        }
        public abstract System.String[] LogicalNames
        {
            get;
        }
        public abstract System.String ManufacturerName
        {
            get;
        }
        public abstract System.Version ServiceObjectVersion
        {
            get;
        }
        public abstract System.Boolean IsDefault
        {
            get;
        }
        public System.Boolean IsDeviceInfoOf(Microsoft.PointOfService.PosCommon serviceObject)
        {
            return false;
        }
        public override System.String ToString()
        {
            return null;
        }
    }
}
