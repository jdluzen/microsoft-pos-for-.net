namespace Microsoft.PointOfService
{
    public interface ILegacyControlObject
    {
        System.String ControlObjectDescription
        {
            get;
        }
        System.Version ControlObjectVersion
        {
            get;
        }
        Microsoft.PointOfService.BinaryConversion BinaryConversion
        {
            get;
            set;
        }
    }
}
