namespace Microsoft.PointOfService
{
    public class DeviceStatusChangedEventArgs : System.EventArgs
    {
        public DeviceStatusChangedEventArgs(Microsoft.PointOfService.Device param_param_device)
        {
        }
        protected DeviceStatusChangedEventArgs()
        {
        }
        public Microsoft.PointOfService.Device Device
        {
            get { return null; }
        }
    }
}
