namespace Microsoft.PointOfService
{
    public class PosControlException : Microsoft.PointOfService.PosException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
    {
        public PosControlException(System.String message, Microsoft.PointOfService.ErrorCode errorCode)
        {
        }
        
        public PosControlException(System.String message, Microsoft.PointOfService.ErrorCode errorCode, System.Int32 errorCodeExtended)
        {
        }
        
        public PosControlException(System.String message, Microsoft.PointOfService.ErrorCode errorCode, System.Exception e)
        {
        }
        
        public PosControlException(System.String message, Microsoft.PointOfService.ErrorCode errorCode, System.Int32 errorCodeExtended, System.Exception e)
        {
        }
        
        protected PosControlException()
        {
        }
        public Microsoft.PointOfService.ErrorCode ErrorCode { get { return Microsoft.PointOfService.ErrorCode.Success; } }
        public System.Int32 ErrorCodeExtended { get { return 0; } }
        public override System.String ToString()
        {
            return null;
        }
        
    }
}
