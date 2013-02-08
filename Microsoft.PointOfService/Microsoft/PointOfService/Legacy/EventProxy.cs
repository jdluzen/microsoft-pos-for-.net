namespace Microsoft.PointOfService.Legacy
{
    public class EventProxy
    {
        public EventProxy()
        {
        }
        public System.Int32 ErrorEventBase(System.Int32 errorCode, System.Int32 errorCodeExtended, System.Int32 errorLocus, System.Int32 errorResponse)
        {
            return 0;
        }
        public void DataEventBase(System.Int32 data)
        {
        }
        public void StatusUpdateEventBase(System.Int32 data)
        {
        }
        public Microsoft.PointOfService.DirectIOEventArgs DirectIOEventBase(Microsoft.PointOfService.DirectIOEventArgs ioEvent)
        {
            return null;
        }
        public void OutputCompleteEventBase(System.Int32 outputId)
        {
        }
    }
}
