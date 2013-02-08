namespace Microsoft.PointOfService
{
    public enum ImageMode
    {
        DecodeOnly = 1,
        StillOnly = 2,
        StillAndDecode = 3,
        VideoAndDecode = 5,
        VideoAndStill = 6,
        All = 255,
    }
}
