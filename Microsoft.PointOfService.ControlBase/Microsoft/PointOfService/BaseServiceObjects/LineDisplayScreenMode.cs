namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class LineDisplayScreenMode : Microsoft.PointOfService.DisplayScreenMode
    {
        public LineDisplayScreenMode(System.Int32 deviceColumns, System.Int32 deviceRows, System.Int32 glyphWidth, System.Int32 glyphHeight)
        {
        }
        
        protected LineDisplayScreenMode()
        {
        }
        public System.Int32 MaximumX { get { return 0; } }
        public System.Int32 MaximumY { get { return 0; } }
        public System.Int32 GlyphHeight { get { return 0; } }
        public System.Int32 GlyphWidth { get { return 0; } }
    }
}
