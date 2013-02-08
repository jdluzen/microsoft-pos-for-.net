namespace Microsoft.PointOfService
{
    public class DeviceErrorEventArgs : Microsoft.PointOfService.PosEventArgs
    {
        public DeviceErrorEventArgs(Microsoft.PointOfService.ErrorCode param_param_errorCode, System.Int32 param_param_errorCodeExtended, Microsoft.PointOfService.ErrorLocus param_param_errorLocus, Microsoft.PointOfService.ErrorResponse param_param_errorResponse)
        {
        }
        protected DeviceErrorEventArgs()
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
        public Microsoft.PointOfService.ErrorLocus ErrorLocus
        {
            get { return Microsoft.PointOfService.ErrorLocus.Output; }
        }
        public Microsoft.PointOfService.ErrorResponse ErrorResponse
        {
            get { return Microsoft.PointOfService.ErrorResponse.Retry; }
            set { }
        }
        public override System.String ToString()
        {
            return null;
        }
    }
}
