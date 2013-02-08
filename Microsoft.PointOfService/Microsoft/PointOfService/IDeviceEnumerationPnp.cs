namespace Microsoft.PointOfService
{
    public interface IDeviceEnumerationPnp : Microsoft.PointOfService.IDeviceEnumeration
    {
        Microsoft.PointOfService.DevicePlugAndPlay GetPlugAndPlayObject();
    }
}
