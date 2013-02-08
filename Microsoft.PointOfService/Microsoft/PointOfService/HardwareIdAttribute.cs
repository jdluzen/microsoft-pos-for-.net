namespace Microsoft.PointOfService
{
    public class HardwareIdAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
    {
        public HardwareIdAttribute(System.String param_param_fromId, System.String param_param_toId)
        {
        }
        public HardwareIdAttribute(System.String param_param_id)
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
