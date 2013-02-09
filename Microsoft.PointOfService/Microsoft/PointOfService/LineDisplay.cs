namespace Microsoft.PointOfService
{
    public abstract class LineDisplay : Microsoft.PointOfService.PosCommon
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
        public abstract Microsoft.PointOfService.DisplayBlink CapBlink { get; }
        public abstract System.Boolean CapBitmap { get; }
        public abstract System.Boolean CapBlinkRate { get; }
        public abstract System.Boolean CapBrightness { get; }
        public abstract Microsoft.PointOfService.CharacterSetCapability CapCharacterSet { get; }
        public abstract Microsoft.PointOfService.DisplayCursors CapCursorType { get; }
        public abstract System.Boolean CapCustomGlyph { get; }
        public abstract System.Boolean CapDescriptors { get; }
        public abstract System.Boolean CapHMarquee { get; }
        public abstract System.Boolean CapICharWait { get; }
        public abstract System.Boolean CapMapCharacterSet { get; }
        public abstract Microsoft.PointOfService.DisplayReadBack CapReadBack { get; }
        public abstract Microsoft.PointOfService.DisplayReverse CapReverse { get; }
        public abstract System.Boolean CapScreenMode { get; }
        public abstract System.Boolean CapVMarquee { get; }
        public abstract System.Int32 BlinkRate { get; set;  }
        public abstract System.Int32 CharacterSet { get; set;  }
        public abstract System.Int32[] CharacterSetList { get; }
        public abstract System.Int32 Columns { get; }
        public abstract System.Int32 CurrentWindow { get; set;  }
        public abstract System.Int32 CursorColumn { get; set;  }
        public abstract System.Int32 CursorRow { get; set;  }
        public abstract Microsoft.PointOfService.DisplayCursors CursorType { get; set;  }
        public abstract System.Boolean CursorUpdate { get; set;  }
        public abstract Microsoft.PointOfService.RangeOfCharacters[] CustomGlyphList { get; }
        public abstract System.Int32 DeviceBrightness { get; set;  }
        public abstract System.Int32 DeviceColumns { get; }
        public abstract System.Int32 DeviceDescriptors { get; }
        public abstract System.Int32 DeviceRows { get; }
        public abstract System.Int32 DeviceWindows { get; }
        public abstract System.Int32 GlyphHeight { get; }
        public abstract System.Int32 GlyphWidth { get; }
        public abstract System.Int32 InterCharacterWait { get; set;  }
        public abstract System.Boolean MapCharacterSet { get; set;  }
        public abstract Microsoft.PointOfService.DisplayMarqueeFormat MarqueeFormat { get; set;  }
        public abstract System.Int32 MarqueeRepeatWait { get; set;  }
        public abstract Microsoft.PointOfService.DisplayMarqueeType MarqueeType { get; set;  }
        public abstract System.Int32 MarqueeUnitWait { get; set;  }
        public abstract System.Int32 MaximumX { get; }
        public abstract System.Int32 MaximumY { get; }
        public abstract System.Int32 Rows { get; }
        public abstract System.Int32 ScreenMode { get; set;  }
        public abstract Microsoft.PointOfService.DisplayScreenMode[] ScreenModeList { get; }
        public virtual void ClearText()
        {
        }
        
        public virtual void DisplayText(System.String data, Microsoft.PointOfService.DisplayTextMode attribute)
        {
        }
        
        public virtual void DisplayText(System.String data)
        {
        }
        
        public virtual void DisplayTextAt(System.Int32 row, System.Int32 column, System.String data, Microsoft.PointOfService.DisplayTextMode attribute)
        {
        }
        
        public virtual void DisplayTextAt(System.Int32 row, System.Int32 column, System.String data)
        {
        }
        
        public virtual void ScrollText(Microsoft.PointOfService.DisplayScrollText direction, System.Int32 units)
        {
        }
        
        public virtual void ClearDescriptors()
        {
        }
        
        public virtual void SetDescriptor(System.Int32 descriptor, Microsoft.PointOfService.DisplaySetDescriptor attribute)
        {
        }
        
        public virtual void CreateWindow(System.Int32 viewportRow, System.Int32 viewportColumn, System.Int32 viewportHeight, System.Int32 viewportWidth, System.Int32 windowHeight, System.Int32 windowWidth)
        {
        }
        
        public virtual void DestroyWindow()
        {
        }
        
        public virtual void RefreshWindow(System.Int32 window)
        {
        }
        
        public virtual void DefineGlyph(System.Int32 glyphCode, System.Byte[] glyph)
        {
        }
        
        public virtual System.Int32 ReadCharacterAtCursor()
        {
            return 0;
        }
        
        public virtual void DisplayBitmap(System.String fileName, System.Int32 width, System.Int32 alignmentX, System.Int32 alignmentY)
        {
        }
        
        public virtual void DisplayBitmap(System.String fileName, System.Int32 alignmentX, System.Int32 alignmentY)
        {
        }
        
        public virtual void SetBitmap(System.Int32 bitmapNumber, System.String fileName, System.Int32 width, System.Int32 alignmentX, System.Int32 alignmentY)
        {
        }
        
        public virtual void SetBitmap(System.Int32 bitmapNumber, System.String fileName, System.Int32 alignmentX, System.Int32 alignmentY)
        {
        }
        
    }
}
