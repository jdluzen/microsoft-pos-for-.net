namespace Microsoft.PointOfService.BasicServiceObjects
{
    public class CommonProperties
    {
        protected CommonProperties()
        {
        }
        public Microsoft.PointOfService.PowerState PowerState { get { return Microsoft.PointOfService.PowerState.Unknown; } set { } }
        public Microsoft.PointOfService.PowerReporting CapPowerReporting { get { return Microsoft.PointOfService.PowerReporting.None; } set { } }
        public System.String DeviceDescription { get { return null; } set { } }
        public System.String DeviceName { get { return null; } set { } }
        public System.String ServiceObjectDescription { get { return null; } set { } }
        public System.Version ServiceObjectVersion { get { return null; } set { } }
        public Microsoft.PointOfService.ControlState State { get { return Microsoft.PointOfService.ControlState.Closed; } set { } }
        public System.Boolean CapStatisticsReporting { get { return false; } set { } }
        public System.Boolean CapUpdateStatistics { get { return false; } set { } }
        public System.Boolean CapCompareFirmwareVersion { get { return false; } set { } }
        public System.Boolean CapUpdateFirmware { get { return false; } set { } }
    }
}
