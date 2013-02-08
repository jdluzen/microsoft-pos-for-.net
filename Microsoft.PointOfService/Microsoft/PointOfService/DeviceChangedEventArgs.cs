namespace Microsoft.PointOfService
{
    public class DeviceChangedEventArgs : System.EventArgs
    {
        public DeviceChangedEventArgs(Microsoft.PointOfService.DeviceInfo param_param_device)
        {
        }
        protected DeviceChangedEventArgs()
        {
        }
        public Microsoft.PointOfService.DeviceInfo Device
        {
            get { return null; }
        }
    }
}
