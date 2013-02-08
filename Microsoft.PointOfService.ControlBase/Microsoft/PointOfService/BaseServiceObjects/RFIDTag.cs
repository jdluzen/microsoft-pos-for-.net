namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class RFIDTag : System.ICloneable
    {
        public RFIDTag()
        {
        }
        public RFIDTag(System.Byte[] param_id)
        {
        }
        public RFIDTag(System.Byte[] param_id, System.Byte[] param_data)
        {
        }
        public RFIDTag(System.Byte[] param_id, System.DateTime param_time)
        {
        }
        public RFIDTag(System.Byte[] param_id, System.Byte[] param_data, System.DateTime param_time)
        {
        }
        public RFIDTag(Microsoft.PointOfService.BaseServiceObjects.RFIDTag param_tag)
        {
        }
        public System.Byte[] TagId
        {
            get { return null; }
            set { }
        }
        public System.Byte[] TagData
        {
            get { return null; }
            set { }
        }
        public System.DateTime Timestamp
        {
            get { return new System.DateTime(); }
            set { }
        }
        public Microsoft.PointOfService.RFIDProtocols Protocol
        {
            get { return Microsoft.PointOfService.RFIDProtocols.EpcClass0; }
            set { }
        }
        public virtual System.Object Clone()
        {
            return null;
        }
    }
}
