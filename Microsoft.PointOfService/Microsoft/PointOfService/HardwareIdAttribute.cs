namespace Microsoft.PointOfService
{
    public class HardwareIdAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
    {
        public HardwareIdAttribute(System.String fromId, System.String toId)
        {
        }
        public HardwareIdAttribute(System.String id)
        {
        }
        protected HardwareIdAttribute()
        {
        }
        public System.String From
        {
            get { return null; }
        }
        public System.String To
        {
            get { return null; }
        }
    }
}
