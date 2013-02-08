namespace Microsoft.PointOfService
{
    public interface IDeviceEnumeration
    {
        System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PointOfService.Device> EnumerateDevices();
    }
}
