namespace Microsoft.PointOfService
{
    public enum PointCardReadWriteState
    {
        Success = 0,
        Start = 211,
        End = 212,
        Parity = 213,
        Encode = 214,
        LrcError = 215,
        Verify = 216,
        Failure = 111,
    }
}
