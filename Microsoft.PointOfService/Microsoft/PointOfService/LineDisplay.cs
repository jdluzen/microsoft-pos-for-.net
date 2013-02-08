namespace Microsoft.PointOfService
{
    public class LineDisplay : Microsoft.PointOfService.PosCommon
    {
        protected LineDisplay()
        {
        }
        public const System.Int32 DisplayBitmapAsIs = -11;
        public const System.Int32 DisplayBitmapLeft = -1;
        public const System.Int32 DisplayBitmapCenter = -2;
        public const System.Int32 DisplayBitmapRight = -3;
        public const System.Int32 DisplayBitmapTop = -1;
        public const System.Int32 DisplayBitmapBottom = -3;
        public const System.Int32 CharacterSetUnicode = 997;
        public const System.Int32 CharacterSetAscii = 998;
        public const System.Int32 CharacterSetAnsi = 999;
        public const System.Int32 ExtendedErrorTooBig = 201;
        public const System.Int32 ExtendedErrorBadFormat = 202;
        public const System.String StatisticOnlineTransitionCount = "OnlineTransitionCount";
        public Microsoft.PointOfService.DisplayBlink CapBlink
        {
            get { return Microsoft.PointOfService.DisplayBlink.None; }
        }
        public System.Boolean CapBitmap
        {
            get { return false; }
        }
        public System.Boolean CapBlinkRate
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
        public System.Int32 BlinkRate
        {
            get { return 0; }
            set { }
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
        public virtual void ClearText()
        {
        }
        public virtual void DisplayText(System.String param_param_data, Microsoft.PointOfService.DisplayTextMode param_param_attribute)
        {
        }
        public virtual void DisplayText(System.String param_param_data)
        {
        }
        public virtual void DisplayTextAt(System.Int32 param_param_row, System.Int32 param_param_column, System.String param_param_data, Microsoft.PointOfService.DisplayTextMode param_param_attribute)
        {
        }
        public virtual void DisplayTextAt(System.Int32 param_param_row, System.Int32 param_param_column, System.String param_param_data)
        {
        }
        public virtual void ScrollText(Microsoft.PointOfService.DisplayScrollText param_param_direction, System.Int32 param_param_units)
        {
        }
        public virtual void ClearDescriptors()
        {
        }
        public virtual void SetDescriptor(System.Int32 param_param_descriptor, Microsoft.PointOfService.DisplaySetDescriptor param_param_attribute)
        {
        }
        public virtual void CreateWindow(System.Int32 param_param_viewportRow, System.Int32 param_param_viewportColumn, System.Int32 param_param_viewportHeight, System.Int32 param_param_viewportWidth, System.Int32 param_param_windowHeight, System.Int32 param_param_windowWidth)
        {
        }
        public virtual void DestroyWindow()
        {
        }
        public virtual void RefreshWindow(System.Int32 param_param_window)
        {
        }
        public virtual void DefineGlyph(System.Int32 param_param_glyphCode, System.Byte[] param_param_glyph)
        {
        }
        public virtual System.Int32 ReadCharacterAtCursor()
        {
            return 0;
        }
        public virtual void DisplayBitmap(System.String param_param_fileName, System.Int32 param_param_width, System.Int32 param_param_alignmentX, System.Int32 param_param_alignmentY)
        {
        }
        public virtual void DisplayBitmap(System.String param_param_fileName, System.Int32 param_param_alignmentX, System.Int32 param_param_alignmentY)
        {
        }
        public virtual void SetBitmap(System.Int32 param_param_bitmapNumber, System.String param_param_fileName, System.Int32 param_param_width, System.Int32 param_param_alignmentX, System.Int32 param_param_alignmentY)
        {
        }
        public virtual void SetBitmap(System.Int32 param_param_bitmapNumber, System.String param_param_fileName, System.Int32 param_param_alignmentX, System.Int32 param_param_alignmentY)
        {
        }
    }
}
