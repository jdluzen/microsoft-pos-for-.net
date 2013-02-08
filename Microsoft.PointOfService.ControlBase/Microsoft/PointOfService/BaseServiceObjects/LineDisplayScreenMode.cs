namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class LineDisplayScreenMode : Microsoft.PointOfService.DisplayScreenMode
    {
        public LineDisplayScreenMode(System.Int32 param_deviceColumns, System.Int32 param_deviceRows, System.Int32 param_glyphWidth, System.Int32 param_glyphHeight)
        {
        }
        protected LineDisplayScreenMode()
        {
        }
        public System.Int32 MaximumX
        {
            get { return 0; }
        }
        public System.Int32 MaximumY
        {
            get { return 0; }
        }
        public System.Int32 GlyphHeight
        {
            get { return 0; }
        }
        public System.Int32 GlyphWidth
        {
            get { return 0; }
        }
    }
}
