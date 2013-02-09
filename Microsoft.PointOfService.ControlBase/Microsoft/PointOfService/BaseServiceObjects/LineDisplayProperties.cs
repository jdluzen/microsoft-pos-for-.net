namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class LineDisplayProperties : Microsoft.PointOfService.BasicServiceObjects.CommonProperties
    {
        protected LineDisplayProperties()
        {
        }
        public System.Int32 MaximumX { get { return 0; } }
        public System.Int32 MaximumY { get { return 0; } }
        public System.Int32 InterCharacterWait { get { return 0; } set { } }
        public System.Int32 CursorColumn { get { return 0; } set { } }
        public System.Int32 CursorRow { get { return 0; } set { } }
        public Microsoft.PointOfService.DisplayCursors CursorType { get { return Microsoft.PointOfService.DisplayCursors.None; } set { } }
        public System.Boolean CursorUpdate { get { return false; } set { } }
        public System.Int32 Rows { get { return 0; } }
        public System.Int32 Columns { get { return 0; } }
        public Microsoft.PointOfService.DisplayMarqueeFormat MarqueeFormat { get { return Microsoft.PointOfService.DisplayMarqueeFormat.Walk; } set { } }
        public System.Int32 MarqueeRepeatWait { get { return 0; } set { } }
        public Microsoft.PointOfService.DisplayMarqueeType MarqueeType { get { return Microsoft.PointOfService.DisplayMarqueeType.None; } set { } }
        public System.Int32 MarqueeUnitWait { get { return 0; } set { } }
        public System.Int32[] CharacterSetList { get { return null; } set { } }
        public System.Boolean MapCharacterSet { get { return false; } set { } }
        public System.Int32 BlinkRate { get { return 0; } set { } }
        public System.Int32 CharacterSet { get { return 0; } set { } }
        public System.Int32 DeviceBrightness { get { return 0; } set { } }
        public System.Int32 CurrentWindow { get { return 0; } set { } }
        public System.Int32 ScreenMode { get { return 0; } set { } }
        public System.Int32 DeviceDescriptors { get { return 0; } set { } }
        public System.Boolean CapDescriptors { get { return false; } set { } }
        public Microsoft.PointOfService.CharacterSetCapability CapCharacterSet { get { return Microsoft.PointOfService.CharacterSetCapability.Numeric; } set { } }
        public Microsoft.PointOfService.DisplayReadBack CapReadBack { get { return Microsoft.PointOfService.DisplayReadBack.None; } set { } }
        public Microsoft.PointOfService.DisplayCursors CapCursorType { get { return Microsoft.PointOfService.DisplayCursors.None; } set { } }
        public Microsoft.PointOfService.RangeOfCharacters[] CustomGlyphList { get { return null; } set { } }
        public System.Int32 DeviceWindows { get { return 0; } set { } }
        public System.Int32 DeviceRows { get { return 0; } }
        public System.Int32 DeviceColumns { get { return 0; } }
        public System.Int32 GlyphHeight { get { return 0; } }
        public System.Int32 GlyphWidth { get { return 0; } }
        public System.Boolean CapScreenMode { get { return false; } }
        public System.Boolean CapVMarquee { get { return false; } set { } }
        public System.Boolean CapBlinkRate { get { return false; } set { } }
        public System.Boolean CapMapCharacterSet { get { return false; } set { } }
        public System.Boolean CapBitmap { get { return false; } set { } }
        public System.Boolean CapICharWait { get { return false; } set { } }
        public System.Boolean CapHMarquee { get { return false; } set { } }
        public Microsoft.PointOfService.DisplayReverse CapReverse { get { return Microsoft.PointOfService.DisplayReverse.None; } set { } }
        public Microsoft.PointOfService.DisplayBlink CapBlink { get { return Microsoft.PointOfService.DisplayBlink.None; } set { } }
        public System.Boolean CapBrightness { get { return false; } set { } }
        public System.Boolean CapCustomGlyph { get { return false; } set { } }
        public Microsoft.PointOfService.DisplayScreenMode[] ScreenModeList { get { return null; } }
    }
}
