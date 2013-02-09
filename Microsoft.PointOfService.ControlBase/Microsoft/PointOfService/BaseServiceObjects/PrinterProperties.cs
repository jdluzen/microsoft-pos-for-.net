namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class PrinterProperties : Microsoft.PointOfService.BasicServiceObjects.CommonProperties
    {
        protected PrinterProperties()
        {
        }
        public System.String TopLogo { get { return null; } }
        public System.String BottomLogo { get { return null; } }
        public System.Boolean RecCoverOpen { get { return false; } set { } }
        public System.Boolean JrnCoverOpen { get { return false; } set { } }
        public System.Boolean SlpCoverOpen { get { return false; } set { } }
        public System.Boolean AsyncMode { get { return false; } set { } }
        public Microsoft.PointOfService.PrinterCartridgeNotify CartridgeNotify { get { return Microsoft.PointOfService.PrinterCartridgeNotify.Disabled; } set { } }
        public System.Int32 CharacterSet { get { return 0; } set { } }
        public System.Int32[] CharacterSetList { get { return null; } set { } }
        public Microsoft.PointOfService.PrinterErrorLevel ErrorLevel { get { return Microsoft.PointOfService.PrinterErrorLevel.None; } set { } }
        public Microsoft.PointOfService.PrinterStation ErrorStation { get { return Microsoft.PointOfService.PrinterStation.None; } set { } }
        public System.String ErrorString { get { return null; } set { } }
        public System.Boolean FlagWhenIdle { get { return false; } set { } }
        public System.String[] FontTypefaceList { get { return null; } set { } }
        public System.Boolean MapCharacterSet { get { return false; } set { } }
        public Microsoft.PointOfService.MapMode MapMode { get { return Microsoft.PointOfService.MapMode.Dots; } set { } }
        public Microsoft.PointOfService.Rotation RotateSpecial { get { return Microsoft.PointOfService.Rotation.Normal; } set { } }
        public Microsoft.PointOfService.CharacterSetCapability CapCharacterSet { get { return Microsoft.PointOfService.CharacterSetCapability.Numeric; } set { } }
        public System.Boolean CapConcurrentJrnRec { get { return false; } set { } }
        public System.Boolean CapConcurrentJrnSlp { get { return false; } set { } }
        public System.Boolean CapConcurrentRecSlp { get { return false; } set { } }
        public System.Boolean CapCoverSensor { get { return false; } set { } }
        public System.Boolean CapMapCharacterSet { get { return false; } set { } }
        public System.Boolean CapTransaction { get { return false; } set { } }
        public System.Boolean CoverOpen { get { return false; } set { } }
        public System.Boolean CapConcurrentPageMode { get { return false; } set { } }
        public System.Boolean CapRecPageMode { get { return false; } set { } }
        public System.Boolean CapSlpPageMode { get { return false; } set { } }
        public Microsoft.PointOfService.PrinterStation PageModeStation { get { return Microsoft.PointOfService.PrinterStation.None; } set { } }
        public System.Int32 PageModeHorizontalPosition { get { return 0; } set { } }
        public System.Int32 PageModeVerticalPosition { get { return 0; } set { } }
        public System.Drawing.Rectangle PageModePrintArea { get { return new System.Drawing.Rectangle(); } set { } }
        public Microsoft.PointOfService.PageModePrintDirection PageModePrintDirection { get { return Microsoft.PointOfService.PageModePrintDirection.None; } set { } }
        public System.Drawing.Point PageModeArea { get { return new System.Drawing.Point(); } set { } }
        public Microsoft.PointOfService.PageModeDescriptors PageModeDescriptor { get { return Microsoft.PointOfService.PageModeDescriptors.None; } set { } }
        public System.Boolean CapJrn2Color { get { return false; } set { } }
        public System.Boolean CapJrnBold { get { return false; } set { } }
        public Microsoft.PointOfService.PrinterCartridgeSensors CapJrnCartridgeSensor { get { return Microsoft.PointOfService.PrinterCartridgeSensors.None; } set { } }
        public Microsoft.PointOfService.PrinterColors CapJrnColor { get { return Microsoft.PointOfService.PrinterColors.None; } set { } }
        public System.Boolean CapJrnDHigh { get { return false; } set { } }
        public System.Boolean CapJrnDWide { get { return false; } set { } }
        public System.Boolean CapJrnDWideDHigh { get { return false; } set { } }
        public System.Boolean CapJrnEmptySensor { get { return false; } set { } }
        public System.Boolean CapJrnItalic { get { return false; } set { } }
        public System.Boolean CapJrnNearEndSensor { get { return false; } set { } }
        public System.Boolean CapJrnPresent { get { return false; } set { } }
        public System.Boolean CapJrnUnderline { get { return false; } set { } }
        public Microsoft.PointOfService.PrinterCartridgeStates JrnCartridgeState { get { return Microsoft.PointOfService.PrinterCartridgeStates.Unknown; } set { } }
        public Microsoft.PointOfService.PrinterColors JrnCurrentCartridge { get { return Microsoft.PointOfService.PrinterColors.None; } set { } }
        public System.Boolean JrnEmpty { get { return false; } set { } }
        public System.Boolean JrnLetterQuality { get { return false; } set { } }
        public System.Int32 JrnLineChars { get { return 0; } set { } }
        public System.Int32[] JrnLineCharsList { get { return null; } set { } }
        public System.Int32 JrnLineHeight { get { return 0; } set { } }
        public System.Int32 JrnLineSpacing { get { return 0; } set { } }
        public System.Int32 JrnLineWidth { get { return 0; } set { } }
        public System.Boolean JrnNearEnd { get { return false; } set { } }
        public System.Boolean CapRec2Color { get { return false; } set { } }
        public System.Boolean CapRecBarCode { get { return false; } set { } }
        public System.Boolean CapRecBitmap { get { return false; } set { } }
        public System.Boolean CapRecBold { get { return false; } set { } }
        public Microsoft.PointOfService.PrinterCartridgeSensors CapRecCartridgeSensor { get { return Microsoft.PointOfService.PrinterCartridgeSensors.None; } set { } }
        public Microsoft.PointOfService.PrinterColors CapRecColor { get { return Microsoft.PointOfService.PrinterColors.None; } set { } }
        public System.Boolean CapRecDHigh { get { return false; } set { } }
        public System.Boolean CapRecDWide { get { return false; } set { } }
        public System.Boolean CapRecDWideDHigh { get { return false; } set { } }
        public System.Boolean CapRecEmptySensor { get { return false; } set { } }
        public System.Boolean CapRecItalic { get { return false; } set { } }
        public System.Boolean CapRecLeft90 { get { return false; } set { } }
        public Microsoft.PointOfService.PrinterMarkFeeds CapRecMarkFeed { get { return Microsoft.PointOfService.PrinterMarkFeeds.None; } set { } }
        public System.Boolean CapRecNearEndSensor { get { return false; } set { } }
        public System.Boolean CapRecPaperCut { get { return false; } set { } }
        public System.Boolean CapRecPresent { get { return false; } set { } }
        public System.Boolean CapRecRight90 { get { return false; } set { } }
        public System.Boolean CapRecRotate180 { get { return false; } set { } }
        public System.Boolean CapRecStamp { get { return false; } set { } }
        public System.Boolean CapRecUnderline { get { return false; } set { } }
        public Microsoft.PointOfService.Rotation[] RecBarCodeRotationList { get { return null; } set { } }
        public Microsoft.PointOfService.Rotation[] RecBitmapRotationList { get { return null; } set { } }
        public Microsoft.PointOfService.PrinterCartridgeStates RecCartridgeState { get { return Microsoft.PointOfService.PrinterCartridgeStates.Unknown; } set { } }
        public Microsoft.PointOfService.PrinterColors RecCurrentCartridge { get { return Microsoft.PointOfService.PrinterColors.None; } set { } }
        public System.Boolean RecEmpty { get { return false; } set { } }
        public System.Boolean RecNearEnd { get { return false; } set { } }
        public System.Boolean RecLetterQuality { get { return false; } set { } }
        public System.Int32 RecLineChars { get { return 0; } set { } }
        public System.Int32[] RecLineCharsList { get { return null; } set { } }
        public System.Int32 RecLineHeight { get { return 0; } set { } }
        public System.Int32 RecLineSpacing { get { return 0; } set { } }
        public System.Int32 RecLinesToPaperCut { get { return 0; } set { } }
        public System.Int32 RecLineWidth { get { return 0; } set { } }
        public System.Int32 RecSidewaysMaxChars { get { return 0; } set { } }
        public System.Int32 RecSidewaysMaxLines { get { return 0; } set { } }
        public System.Boolean CapSlp2Color { get { return false; } set { } }
        public System.Boolean CapSlpBarCode { get { return false; } set { } }
        public System.Boolean CapSlpBitmap { get { return false; } set { } }
        public System.Boolean CapSlpBold { get { return false; } set { } }
        public System.Boolean CapSlpBothSidesPrint { get { return false; } set { } }
        public Microsoft.PointOfService.PrinterCartridgeSensors CapSlpCartridgeSensor { get { return Microsoft.PointOfService.PrinterCartridgeSensors.None; } set { } }
        public Microsoft.PointOfService.PrinterColors CapSlpColor { get { return Microsoft.PointOfService.PrinterColors.None; } set { } }
        public System.Boolean CapSlpDHigh { get { return false; } set { } }
        public System.Boolean CapSlpDWide { get { return false; } set { } }
        public System.Boolean CapSlpDWideDHigh { get { return false; } set { } }
        public System.Boolean CapSlpEmptySensor { get { return false; } set { } }
        public System.Boolean CapSlpFullSlip { get { return false; } set { } }
        public System.Boolean CapSlpItalic { get { return false; } set { } }
        public System.Boolean CapSlpLeft90 { get { return false; } set { } }
        public System.Boolean CapSlpNearEndSensor { get { return false; } set { } }
        public System.Boolean CapSlpPresent { get { return false; } set { } }
        public System.Boolean CapSlpRight90 { get { return false; } set { } }
        public System.Boolean CapSlpRotate180 { get { return false; } set { } }
        public System.Boolean CapSlpUnderline { get { return false; } set { } }
        public Microsoft.PointOfService.Rotation[] SlpBarCodeRotationList { get { return null; } set { } }
        public Microsoft.PointOfService.Rotation[] SlpBitmapRotationList { get { return null; } set { } }
        public Microsoft.PointOfService.PrinterCartridgeStates SlpCartridgeState { get { return Microsoft.PointOfService.PrinterCartridgeStates.Unknown; } set { } }
        public Microsoft.PointOfService.PrinterColors SlpCurrentCartridge { get { return Microsoft.PointOfService.PrinterColors.None; } set { } }
        public System.Boolean SlpEmpty { get { return false; } set { } }
        public System.Boolean SlpLetterQuality { get { return false; } set { } }
        public System.Int32 SlpLineChars { get { return 0; } set { } }
        public System.Int32[] SlpLineCharsList { get { return null; } set { } }
        public System.Int32 SlpLineHeight { get { return 0; } set { } }
        public System.Int32 SlpLinesNearEndToEnd { get { return 0; } set { } }
        public System.Int32 SlpLineSpacing { get { return 0; } set { } }
        public System.Int32 SlpLineWidth { get { return 0; } set { } }
        public System.Int32 SlpMaxLines { get { return 0; } set { } }
        public System.Boolean SlpNearEnd { get { return false; } set { } }
        public Microsoft.PointOfService.PrinterSide SlpPrintSide { get { return Microsoft.PointOfService.PrinterSide.Unknown; } set { } }
        public System.Int32 SlpSidewaysMaxChars { get { return 0; } set { } }
        public System.Int32 SlpSidewaysMaxLines { get { return 0; } set { } }
    }
}
