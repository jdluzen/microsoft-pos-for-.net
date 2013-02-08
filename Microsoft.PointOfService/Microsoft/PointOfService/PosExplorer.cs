namespace Microsoft.PointOfService
{
    public class PosExplorer
    {
        public PosExplorer()
        {
        }
        public PosExplorer(System.ComponentModel.ISynchronizeInvoke param_param_synchronizingObject)
        {
        }
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject
        {
            get { return null; }
            set { }
        }
        public System.String PosRegistryKey
        {
            get { return null; }
        }
        public System.String StatisticsFile
        {
            get { return null; }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceChangedEventHandler DeviceAddedEvent;
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceChangedEventHandler DeviceRemovedEvent;
        public void Refresh()
        {
        }
        public Microsoft.PointOfService.DeviceCollection GetDevices(System.String param_param_type)
        {
            return null;
        }
        public Microsoft.PointOfService.DeviceCollection GetDevices(System.String param_param_type, Microsoft.PointOfService.DeviceCompatibilities param_param_compatibility)
        {
            return null;
        }
        public Microsoft.PointOfService.DeviceCollection GetDevices()
        {
            return null;
        }
        public Microsoft.PointOfService.DeviceCollection GetDevices(Microsoft.PointOfService.DeviceCompatibilities param_param_compatibility)
        {
            return null;
        }
        public Microsoft.PointOfService.DeviceInfo GetDevice(System.String param_param_type)
        {
            return null;
        }
        public Microsoft.PointOfService.DeviceInfo GetDevice(System.String param_param_type, System.String param_param_logicalName)
        {
            return null;
        }
        public Microsoft.PointOfService.PosDevice CreateInstance(Microsoft.PointOfService.DeviceInfo param_param_device)
        {
            return null;
        }
    }
}
