namespace Microsoft.PointOfService
{
    public abstract class PosException : System.Exception, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
    {
        protected PosException()
        {
        }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
        }
        
    }
}
