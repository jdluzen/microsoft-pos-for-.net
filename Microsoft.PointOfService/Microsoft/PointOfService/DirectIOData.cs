namespace Microsoft.PointOfService
{
    public struct DirectIOData
    {
        public DirectIOData(System.Int32 data, System.Object obj)
        {
        }
        
        public System.Int32 Data { get { return 0; } }
        public System.Object Object { get { return null; } }
        public System.Boolean Equals(Microsoft.PointOfService.DirectIOData d)
        {
            return false;
        }
        
        public override System.Boolean Equals(System.Object obj)
        {
            return false;
        }
        
        public static System.Boolean Equals(Microsoft.PointOfService.DirectIOData a, Microsoft.PointOfService.DirectIOData b)
        {
            return false;
        }
        
        public static System.Boolean operator ==(Microsoft.PointOfService.DirectIOData a, System.Object b)
        {
            return false;
        }
        
        public static System.Boolean operator !=(Microsoft.PointOfService.DirectIOData a, System.Object b)
        {
            return false;
        }
        
        public override System.Int32 GetHashCode()
        {
            return 0;
        }
        
        public override System.String ToString()
        {
            return null;
        }
        
    }
}
