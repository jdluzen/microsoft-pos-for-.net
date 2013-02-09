namespace Microsoft.PointOfService
{
    public class DeviceChangedEventArgs : System.EventArgs
    {
        public DeviceChangedEventArgs(Microsoft.PointOfService.DeviceInfo device)
        {
        }
        
        protected DeviceChangedEventArgs()
        {
        }
        public Microsoft.PointOfService.DeviceInfo Device { get { return null; } }
    }
}
