namespace Microsoft.PointOfService
{
    public class DevicePlugAndPlay : System.MarshalByRefObject
    {
        protected DevicePlugAndPlay()
        {
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceStatusChangedEventHandler DeviceAddedEvent;
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceStatusChangedEventHandler DeviceRemovedEvent;
    }
}
