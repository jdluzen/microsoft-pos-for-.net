namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class LineDisplayBase : Microsoft.PointOfService.BasicServiceObjects.LineDisplayBasic, System.IDisposable
    {
        protected LineDisplayBase()
        {
        }
        public System.Int32 BlinkRate
        {
            get { return 0; }
            set { }
        }
        public Microsoft.PointOfService.DisplayBlink CapBlink
        {
            get { return Microsoft.PointOfService.DisplayBlink.None; }
        }
        public System.Boolean CapBlinkRate
        {
            get { return false; }
        }
        public System.Boolean CapBitmap
        {
            get { return false; }
        }
        public System.Boolean CapBrightness
        {
            get { return false; }
        }
        public Microsoft.PointOfService.CharacterSetCapability CapCharacterSet
        {
            get { return Microsoft.PointOfService.CharacterSetCapability.Numeric; }
        }
        public Microsoft.PointOfService.DisplayCursors CapCursorType
        {
            get { return Microsoft.PointOfService.DisplayCursors.None; }
        }
        public System.Boolean CapCustomGlyph
        {
            get { return false; }
        }
        public System.Boolean CapDescriptors
        {
            get { return false; }
        }
        public System.Boolean CapHMarquee
        {
            get { return false; }
        }
        public System.Boolean CapICharWait
        {
            get { return false; }
        }
        public System.Boolean CapMapCharacterSet
        {
            get { return false; }
        }
        public Microsoft.PointOfService.DisplayReadBack CapReadBack
        {
            get { return Microsoft.PointOfService.DisplayReadBack.None; }
        }
        public Microsoft.PointOfService.DisplayReverse CapReverse
        {
            get { return Microsoft.PointOfService.DisplayReverse.None; }
        }
        public System.Boolean CapScreenMode
        {
            get { return false; }
        }
        public System.Boolean CapVMarquee
        {
            get { return false; }
        }
        public System.Int32 CharacterSet
        {
            get { return 0; }
            set { }
        }
        public System.Int32[] CharacterSetList
        {
            get { return null; }
        }
        public System.Int32 Columns
        {
            get { return 0; }
        }
        public System.Int32 CurrentWindow
        {
            get { return 0; }
            set { }
        }
        public System.Int32 CursorColumn
        {
            get { return 0; }
            set { }
        }
        public System.Int32 CursorRow
        {
            get { return 0; }
            set { }
        }
        public Microsoft.PointOfService.DisplayCursors CursorType
        {
            get { return Microsoft.PointOfService.DisplayCursors.None; }
            set { }
        }
        public System.Boolean CursorUpdate
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.RangeOfCharacters[] CustomGlyphList
        {
            get { return null; }
        }
        public System.Int32 DeviceBrightness
        {
            get { return 0; }
            set { }
        }
        public System.Int32 DeviceColumns
        {
            get { return 0; }
        }
        public System.Int32 DeviceDescriptors
        {
            get { return 0; }
        }
        public System.Int32 DeviceRows
        {
            get { return 0; }
        }
        public System.Int32 DeviceWindows
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
        public System.Int32 InterCharacterWait
        {
            get { return 0; }
            set { }
        }
        public System.Boolean MapCharacterSet
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.DisplayMarqueeFormat MarqueeFormat
        {
            get { return Microsoft.PointOfService.DisplayMarqueeFormat.Walk; }
            set { }
        }
        public System.Int32 MarqueeRepeatWait
        {
            get { return 0; }
            set { }
        }
        public Microsoft.PointOfService.DisplayMarqueeType MarqueeType
        {
            get { return Microsoft.PointOfService.DisplayMarqueeType.None; }
            set { }
        }
        public System.Int32 MarqueeUnitWait
        {
            get { return 0; }
            set { }
        }
        public System.Int32 MaximumX
        {
            get { return 0; }
        }
        public System.Int32 MaximumY
        {
            get { return 0; }
        }
        public System.Int32 Rows
        {
            get { return 0; }
        }
        public System.Int32 ScreenMode
        {
            get { return 0; }
            set { }
        }
        public Microsoft.PointOfService.DisplayScreenMode[] ScreenModeList
        {
            get { return null; }
        }
        public override void ClearText()
        {
        }
        public override void CreateWindow(System.Int32 viewportRow, System.Int32 viewportColumn, System.Int32 viewportHeight, System.Int32 viewportWidth, System.Int32 windowHeight, System.Int32 windowWidth)
        {
        }
        public override void DefineGlyph(System.Int32 glyphCode, System.Byte[] glyph)
        {
        }
        public override void DisplayText(System.String data)
        {
        }
        public override void DisplayText(System.String data, Microsoft.PointOfService.DisplayTextMode attribute)
        {
        }
        public override void RefreshWindow(System.Int32 window)
        {
        }
        public override void DisplayTextAt(System.Int32 row, System.Int32 column, System.String data)
        {
        }
        public override void DisplayTextAt(System.Int32 row, System.Int32 column, System.String data, Microsoft.PointOfService.DisplayTextMode attribute)
        {
        }
        public override void ScrollText(Microsoft.PointOfService.DisplayScrollText direction, System.Int32 units)
        {
        }
        public override void DestroyWindow()
        {
        }
        public override void ClearDescriptors()
        {
        }
        public override void SetDescriptor(System.Int32 descriptor, Microsoft.PointOfService.DisplaySetDescriptor attribute)
        {
        }
        public override System.Int32 ReadCharacterAtCursor()
        {
            return 0;
        }
        public override void DisplayBitmap(System.String fileName, System.Int32 alignmentX, System.Int32 alignmentY)
        {
        }
        public override void DisplayBitmap(System.String fileName, System.Int32 width, System.Int32 alignmentX, System.Int32 alignmentY)
        {
        }
        public override void SetBitmap(System.Int32 bitmapNumber, System.String fileName, System.Int32 alignmentX, System.Int32 alignmentY)
        {
        }
        public override void SetBitmap(System.Int32 bitmapNumber, System.String fileName, System.Int32 width, System.Int32 alignmentX, System.Int32 alignmentY)
        {
        }
        public override void Open()
        {
        }
    }
}
