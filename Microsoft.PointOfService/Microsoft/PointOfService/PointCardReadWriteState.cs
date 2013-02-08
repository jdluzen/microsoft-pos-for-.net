namespace Microsoft.PointOfService
{
    public enum PointCardReadWriteState
    {
        Success,
        Start,
        End,
        Parity,
        Encode,
        LrcError,
        Verify,
        Failure,
    }
}
