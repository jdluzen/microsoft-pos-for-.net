namespace Microsoft.PointOfService.Legacy
{
    public class EventProxy
    {
        public EventProxy()
        {
        }
        public System.Int32 ErrorEventBase(System.Int32 param_param_errorCode, System.Int32 param_param_errorCodeExtended, System.Int32 param_param_errorLocus, System.Int32 param_param_errorResponse)
        {
            return 0;
        }
        public void DataEventBase(System.Int32 param_param_data)
        {
        }
        public void StatusUpdateEventBase(System.Int32 param_param_data)
        {
        }
        public Microsoft.PointOfService.DirectIOEventArgs DirectIOEventBase(Microsoft.PointOfService.DirectIOEventArgs param_param_ioEvent)
        {
            return null;
        }
        public void OutputCompleteEventBase(System.Int32 param_param_outputId)
        {
        }
    }
}
