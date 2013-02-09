namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class RFIDTag : System.ICloneable
    {
        public RFIDTag()
        {
        }
        
        public RFIDTag(System.Byte[] id)
        {
        }
        
        public RFIDTag(System.Byte[] id, System.Byte[] data)
        {
        }
        
        public RFIDTag(System.Byte[] id, System.DateTime time)
        {
        }
        
        public RFIDTag(System.Byte[] id, System.Byte[] data, System.DateTime time)
        {
        }
        
        public RFIDTag(Microsoft.PointOfService.BaseServiceObjects.RFIDTag tag)
        {
        }
        
        public System.Byte[] TagId { get { return null; } set { } }
        public System.Byte[] TagData { get { return null; } set { } }
        public System.DateTime Timestamp { get { return new System.DateTime(); } set { } }
        public Microsoft.PointOfService.RFIDProtocols Protocol { get { return Microsoft.PointOfService.RFIDProtocols.EpcClass0; } set { } }
        public virtual System.Object Clone()
        {
            return null;
        }
        
    }
}
