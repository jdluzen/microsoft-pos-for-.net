namespace Microsoft.PointOfService
{
    public class PosControlException : Microsoft.PointOfService.PosException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
    {
        public PosControlException(System.String param_param_message, Microsoft.PointOfService.ErrorCode param_param_errorCode)
        {
        }
        public PosControlException(System.String param_param_message, Microsoft.PointOfService.ErrorCode param_param_errorCode, System.Int32 param_param_errorCodeExtended)
        {
        }
        public PosControlException(System.String param_param_message, Microsoft.PointOfService.ErrorCode param_param_errorCode, System.Exception param_param_e)
        {
        }
        public PosControlException(System.String param_param_message, Microsoft.PointOfService.ErrorCode param_param_errorCode, System.Int32 param_param_errorCodeExtended, System.Exception param_param_e)
        {
        }
        protected PosControlException()
        {
        }
        public Microsoft.PointOfService.ErrorCode ErrorCode
        {
            get { return Microsoft.PointOfService.ErrorCode.Success; }
        }
        public System.Int32 ErrorCodeExtended
        {
            get { return 0; }
        }
        public override System.String ToString()
        {
            return null;
        }
    }
}
