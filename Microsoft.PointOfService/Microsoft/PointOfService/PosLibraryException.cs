namespace Microsoft.PointOfService
{
    public class PosLibraryException : Microsoft.PointOfService.PosException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
    {
        public PosLibraryException()
        {
        }
        
        public PosLibraryException(System.String message)
        {
        }
        
        public PosLibraryException(System.String message, System.Exception e)
        {
        }
        
    }
}
