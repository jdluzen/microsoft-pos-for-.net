namespace Microsoft.PointOfService
{
    public enum RFIDProtocols
    {
        EpcClass0 = 1,
        RFIDSdt0Plus = 2,
        EpcClass1 = 4,
        EpcClass1Gen2 = 8,
        EpcClass2 = 16,
        Iso14443A = 4096,
        Iso14443B = 8192,
        Iso15693 = 12288,
        Iso180006B = 16384,
        Other = 16777216,
        All = 1073741824,
    }
}
