namespace Microsoft.PointOfService
{
    public struct VideoMode
    {
        public VideoMode(System.Int32 rows, System.Int32 columns, System.Int32 colors, System.Boolean isColor)
        {
        }
        public VideoMode(System.Int32 modeId, System.Int32 rows, System.Int32 columns, System.Int32 colors, System.Boolean isColor)
        {
        }
        public System.Int32 ModeId
        {
            get { return 0; }
        }
        public System.Int32 Rows
        {
            get { return 0; }
        }
        public System.Int32 Columns
        {
            get { return 0; }
        }
        public System.Int32 Colors
        {
            get { return 0; }
        }
        public System.Boolean IsColor
        {
            get { return false; }
        }
        public System.Boolean Equals(Microsoft.PointOfService.VideoMode mode)
        {
            return false;
        }
        public override System.Boolean Equals(System.Object obj)
        {
            return false;
        }
        public static System.Boolean Equals(Microsoft.PointOfService.VideoMode a, Microsoft.PointOfService.VideoMode b)
        {
            return false;
        }
        public static System.Boolean operator ==(Microsoft.PointOfService.VideoMode a, System.Object b)
        {
            return false;
        }
        public static System.Boolean operator !=(Microsoft.PointOfService.VideoMode a, System.Object b)
        {
            return false;
        }
        public override System.Int32 GetHashCode()
        {
            return 0;
        }
    }
}
