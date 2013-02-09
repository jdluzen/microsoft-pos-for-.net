namespace Microsoft.PointOfService
{
    public class PosExplorer
    {
        public PosExplorer()
        {
        }
        
        public PosExplorer(System.ComponentModel.ISynchronizeInvoke synchronizingObject)
        {
        }
        
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return null; } set { } }
        public System.String PosRegistryKey { get { return null; } }
        public System.String StatisticsFile { get { return null; } }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceChangedEventHandler DeviceAddedEvent;
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceChangedEventHandler DeviceRemovedEvent;
        public void Refresh()
        {
        }
        
        public Microsoft.PointOfService.DeviceCollection GetDevices(System.String type)
        {
            return null;
        }
        
        public Microsoft.PointOfService.DeviceCollection GetDevices(System.String type, Microsoft.PointOfService.DeviceCompatibilities compatibility)
        {
            return null;
        }
        
        public Microsoft.PointOfService.DeviceCollection GetDevices()
        {
            return null;
        }
        
        public Microsoft.PointOfService.DeviceCollection GetDevices(Microsoft.PointOfService.DeviceCompatibilities compatibility)
        {
            return null;
        }
        
        public Microsoft.PointOfService.DeviceInfo GetDevice(System.String type)
        {
            return null;
        }
        
        public Microsoft.PointOfService.DeviceInfo GetDevice(System.String type, System.String logicalName)
        {
            return null;
        }
        
        public Microsoft.PointOfService.PosDevice CreateInstance(Microsoft.PointOfService.DeviceInfo device)
        {
            return null;
        }
        
    }
}
