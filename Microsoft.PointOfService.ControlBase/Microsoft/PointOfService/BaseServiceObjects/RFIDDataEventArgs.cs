namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class RFIDDataEventArgs : Microsoft.PointOfService.DataEventArgs
    {
        public RFIDDataEventArgs(System.Byte[] param_id, System.Byte[] param_data, System.DateTime param_time)
        {
        }
        public RFIDDataEventArgs(Microsoft.PointOfService.BaseServiceObjects.RFIDTag param_tag)
        {
        }
        public RFIDDataEventArgs(System.Collections.Generic.ICollection<Microsoft.PointOfService.BaseServiceObjects.RFIDTag> param_currentTags)
        {
        }
        protected RFIDDataEventArgs()
        {
        }
        public System.Collections.Generic.IList<Microsoft.PointOfService.BaseServiceObjects.RFIDTag> CurrentTags
        {
            get { return null; }
        }
    }
}
