namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class RFIDDataEventArgs : Microsoft.PointOfService.DataEventArgs
    {
        public RFIDDataEventArgs(System.Byte[] id, System.Byte[] data, System.DateTime time)
        {
        }
        
        public RFIDDataEventArgs(Microsoft.PointOfService.BaseServiceObjects.RFIDTag tag)
        {
        }
        
        public RFIDDataEventArgs(System.Collections.Generic.ICollection<Microsoft.PointOfService.BaseServiceObjects.RFIDTag> currentTags)
        {
        }
        
        protected RFIDDataEventArgs()
        {
        }
        public System.Collections.Generic.IList<Microsoft.PointOfService.BaseServiceObjects.RFIDTag> CurrentTags { get { return null; } }
    }
}
