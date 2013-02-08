namespace Microsoft.PointOfService
{
    public enum ErrorCode
    {
        Success = 0,
        Closed = 101,
        Claimed = 102,
        NotClaimed = 103,
        NoService = 104,
        Disabled = 105,
        Illegal = 106,
        NoHardware = 107,
        Offline = 108,
        NoExist = 109,
        Exists = 110,
        Failure = 111,
        Timeout = 112,
        Busy = 113,
        Extended = 114,
        Deprecated = 115,
    }
}
