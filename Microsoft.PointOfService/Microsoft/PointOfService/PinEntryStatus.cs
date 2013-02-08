namespace Microsoft.PointOfService
{
    public enum PinEntryStatus
    {
        Success = 1,
        Cancel = 2,
        Timeout = 3,
        BadKey = 201,
        Error = 100,
    }
}
