namespace Microsoft.PointOfService
{
    public class PosPrinter : Microsoft.PointOfService.PosCommon
    {
        protected PosPrinter()
        {
        }
        public const System.Int32 PrinterBitmapAsIs = -11;
        public const System.Int32 PrinterCutPaperFullCut = 100;
        public const System.Int32 PrinterBitmapLeft = -1;
        public const System.Int32 PrinterBitmapCenter = -2;
        public const System.Int32 PrinterBitmapRight = -3;
        public const System.Int32 PrinterBarCodeLeft = -1;
        public const System.Int32 PrinterBarCodeCenter = -2;
        public const System.Int32 PrinterBarCodeRight = -3;
        public const System.Int32 CharacterSetUnicode = 997;
        public const System.Int32 CharacterSetAscii = 998;
        public const System.Int32 CharacterSetAnsi = 999;
        public const System.Int32 ExtendedErrorCoverOpen = 201;
        public const System.Int32 ExtendedErrorJournalEmpty = 202;
        public const System.Int32 ExtendedErrorReceiptEmpty = 203;
        public const System.Int32 ExtendedErrorSlipEmpty = 204;
        public const System.Int32 ExtendedErrorSlipForm = 205;
        public const System.Int32 ExtendedErrorTooBig = 206;
        public const System.Int32 ExtendedErrorBadFormat = 207;
        public const System.Int32 ExtendedErrorJournalCartridgeRemoved = 208;
        public const System.Int32 ExtendedErrorJournalCartridgeEmpty = 209;
        public const System.Int32 ExtendedErrorJournalHeadCleaning = 210;
        public const System.Int32 ExtendedErrorReceiptCartridgeRemoved = 211;
        public const System.Int32 ExtendedErrorReceiptCartridgeEmpty = 212;
        public const System.Int32 ExtendedErrorReceiptHeadCleaning = 213;
        public const System.Int32 ExtendedErrorSlipCartridgeRemoved = 214;
        public const System.Int32 ExtendedErrorSlipCartridgeEmpty = 215;
        public const System.Int32 ExtendedErrorSlipHeadCleaning = 216;
        public const System.Int32 StatusCoverOpen = 11;
        public const System.Int32 StatusCoverOK = 12;
        public const System.Int32 StatusJournalEmpty = 21;
        public const System.Int32 StatusJournalNearEmpty = 22;
        public const System.Int32 StatusJournalPaperOK = 23;
        public const System.Int32 StatusReceiptEmpty = 24;
        public const System.Int32 StatusReceiptNearEmpty = 25;
        public const System.Int32 StatusReceiptPaperOK = 26;
        public const System.Int32 StatusSlipEmpty = 27;
        public const System.Int32 StatusSlipNearEmpty = 28;
        public const System.Int32 StatusSlipPaperOK = 29;
        public const System.Int32 StatusJournalCartridgeEmpty = 41;
        public const System.Int32 StatusJournalCartridgeNearEmpty = 42;
        public const System.Int32 StatusJournalHeadCleaning = 43;
        public const System.Int32 StatusJournalCartridgeOK = 44;
        public const System.Int32 StatusReceiptCartridgeEmpty = 45;
        public const System.Int32 StatusReceiptCartridgeNearEmpty = 46;
        public const System.Int32 StatusReceiptHeadCleaning = 47;
        public const System.Int32 StatusReceiptCartridgeOK = 48;
        public const System.Int32 StatusSlipCartridgeEmpty = 49;
        public const System.Int32 StatusSlipCartridgeNearEmpty = 50;
        public const System.Int32 StatusSlipHeadCleaning = 51;
        public const System.Int32 StatusSlipCartridgeOK = 52;
        public const System.Int32 StatusJournalCoverOpen = 60;
        public const System.Int32 StatusJournalCoverOK = 61;
        public const System.Int32 StatusReceiptCoverOpen = 62;
        public const System.Int32 StatusReceiptCoverOK = 63;
        public const System.Int32 StatusSlipCoverOpen = 64;
        public const System.Int32 StatusSlipCoverOK = 65;
        public const System.Int32 StatusIdle = 1001;
        public const System.String StatisticBarcodePrintedCount = "BarcodePrintedCount";
        public const System.String StatisticFormInsertionCount = "FormInsertionCount";
        public const System.String StatisticHomeErrorCount = "HomeErrorCount";
        public const System.String StatisticJournalCharacterPrintedCount = "JournalCharacterPrintedCount";
        public const System.String StatisticJournalCoverOpenCount = "JournalCoverOpenCount";
        public const System.String StatisticJournalLinePrintedCount = "JournalLinePrintedCount";
        public const System.String StatisticMaximumTempReachedCount = "MaximumTempReachedCount";
        public const System.String StatisticNVRAMWriteCount = "NVRAMWriteCount";
        public const System.String StatisticPaperCutCount = "PaperCutCount";
        public const System.String StatisticFailedPaperCutCount = "FailedPaperCutCount";
        public const System.String StatisticPrinterFaultCount = "PrinterFaultCount";
        public const System.String StatisticPrintSideChangeCount = "PrintSideChangeCount";
        public const System.String StatisticFailedPrintSideChangeCount = "FailedPrintSideChangeCount";
        public const System.String StatisticReceiptCharacterPrintedCount = "ReceiptCharacterPrintedCount";
        public const System.String StatisticReceiptCoverOpenCount = "ReceiptCoverOpenCount";
        public const System.String StatisticReceiptLineFeedCount = "ReceiptLineFeedCount";
        public const System.String StatisticReceiptLinePrintedCount = "ReceiptLinePrintedCount";
        public const System.String StatisticSlipCharacterPrintedCount = "SlipCharacterPrintedCount";
        public const System.String StatisticSlipCoverOpenCount = "SlipCoverOpenCount";
        public const System.String StatisticSlipLineFeedCount = "SlipLineFeedCount";
        public const System.String StatisticSlipLinePrintedCount = "SlipLinePrintedCount";
        public const System.String StatisticStampFiredCount = "StampFiredCount";
        public System.Int32 OutputId
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.CharacterSetCapability CapCharacterSet
        {
            get { return Microsoft.PointOfService.CharacterSetCapability.Numeric; }
        }
        public System.Boolean CapConcurrentJrnRec
        {
            get { return false; }
        }
        public System.Boolean CapConcurrentJrnSlp
        {
            get { return false; }
        }
        public System.Boolean CapConcurrentRecSlp
        {
            get { return false; }
        }
        public System.Boolean CapCoverSensor
        {
            get { return false; }
        }
        public System.Boolean CapMapCharacterSet
        {
            get { return false; }
        }
        public System.Boolean CapTransaction
        {
            get { return false; }
        }
        public System.Boolean CapJrnPresent
        {
            get { return false; }
        }
        public System.Boolean CapJrn2Color
        {
            get { return false; }
        }
        public System.Boolean CapJrnBold
        {
            get { return false; }
        }
        public System.Boolean CapJrnDHigh
        {
            get { return false; }
        }
        public System.Boolean CapJrnDWide
        {
            get { return false; }
        }
        public System.Boolean CapJrnDWideDHigh
        {
            get { return false; }
        }
        public System.Boolean CapJrnEmptySensor
        {
            get { return false; }
        }
        public System.Boolean CapJrnItalic
        {
            get { return false; }
        }
        public System.Boolean CapJrnNearEndSensor
        {
            get { return false; }
        }
        public System.Boolean CapJrnUnderline
        {
            get { return false; }
        }
        public Microsoft.PointOfService.PrinterCartridgeSensors CapJrnCartridgeSensor
        {
            get { return Microsoft.PointOfService.PrinterCartridgeSensors.None; }
        }
        public Microsoft.PointOfService.PrinterColors CapJrnColor
        {
            get { return Microsoft.PointOfService.PrinterColors.None; }
        }
        public System.Boolean CapRecPresent
        {
            get { return false; }
        }
        public System.Boolean CapRec2Color
        {
            get { return false; }
        }
        public System.Boolean CapRecBarCode
        {
            get { return false; }
        }
        public System.Boolean CapRecBitmap
        {
            get { return false; }
        }
        public System.Boolean CapRecBold
        {
            get { return false; }
        }
        public System.Boolean CapRecDHigh
        {
            get { return false; }
        }
        public System.Boolean CapRecDWide
        {
            get { return false; }
        }
        public System.Boolean CapRecDWideDHigh
        {
            get { return false; }
        }
        public System.Boolean CapRecEmptySensor
        {
            get { return false; }
        }
        public System.Boolean CapRecItalic
        {
            get { return false; }
        }
        public System.Boolean CapRecLeft90
        {
            get { return false; }
        }
        public System.Boolean CapRecNearEndSensor
        {
            get { return false; }
        }
        public System.Boolean CapRecPaperCut
        {
            get { return false; }
        }
        public System.Boolean CapRecRight90
        {
            get { return false; }
        }
        public System.Boolean CapRecRotate180
        {
            get { return false; }
        }
        public System.Boolean CapRecStamp
        {
            get { return false; }
        }
        public System.Boolean CapRecUnderline
        {
            get { return false; }
        }
        public Microsoft.PointOfService.PrinterCartridgeSensors CapRecCartridgeSensor
        {
            get { return Microsoft.PointOfService.PrinterCartridgeSensors.None; }
        }
        public Microsoft.PointOfService.PrinterColors CapRecColor
        {
            get { return Microsoft.PointOfService.PrinterColors.None; }
        }
        public Microsoft.PointOfService.PrinterMarkFeeds CapRecMarkFeed
        {
            get { return Microsoft.PointOfService.PrinterMarkFeeds.None; }
        }
        public System.Boolean CapSlpPresent
        {
            get { return false; }
        }
        public System.Boolean CapSlpFullSlip
        {
            get { return false; }
        }
        public System.Boolean CapSlp2Color
        {
            get { return false; }
        }
        public System.Boolean CapSlpBarCode
        {
            get { return false; }
        }
        public System.Boolean CapSlpBitmap
        {
            get { return false; }
        }
        public System.Boolean CapSlpBold
        {
            get { return false; }
        }
        public System.Boolean CapSlpDHigh
        {
            get { return false; }
        }
        public System.Boolean CapSlpDWide
        {
            get { return false; }
        }
        public System.Boolean CapSlpDWideDHigh
        {
            get { return false; }
        }
        public System.Boolean CapSlpEmptySensor
        {
            get { return false; }
        }
        public System.Boolean CapSlpItalic
        {
            get { return false; }
        }
        public System.Boolean CapSlpLeft90
        {
            get { return false; }
        }
        public System.Boolean CapSlpNearEndSensor
        {
            get { return false; }
        }
        public System.Boolean CapSlpRight90
        {
            get { return false; }
        }
        public System.Boolean CapSlpRotate180
        {
            get { return false; }
        }
        public System.Boolean CapSlpUnderline
        {
            get { return false; }
        }
        public System.Boolean CapSlpBothSidesPrint
        {
            get { return false; }
        }
        public Microsoft.PointOfService.PrinterCartridgeSensors CapSlpCartridgeSensor
        {
            get { return Microsoft.PointOfService.PrinterCartridgeSensors.None; }
        }
        public Microsoft.PointOfService.PrinterColors CapSlpColor
        {
            get { return Microsoft.PointOfService.PrinterColors.None; }
        }
        public System.Boolean AsyncMode
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.PrinterCartridgeNotify CartridgeNotify
        {
            get { return Microsoft.PointOfService.PrinterCartridgeNotify.Disabled; }
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
        public System.Boolean CoverOpen
        {
            get { return false; }
        }
        public Microsoft.PointOfService.PrinterErrorLevel ErrorLevel
        {
            get { return Microsoft.PointOfService.PrinterErrorLevel.None; }
        }
        public Microsoft.PointOfService.PrinterStation ErrorStation
        {
            get { return Microsoft.PointOfService.PrinterStation.None; }
        }
        public System.String ErrorString
        {
            get { return null; }
        }
        public System.String[] FontTypefaceList
        {
            get { return null; }
        }
        public System.Boolean FlagWhenIdle
        {
            get { return false; }
            set { }
        }
        public System.Boolean MapCharacterSet
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.MapMode MapMode
        {
            get { return Microsoft.PointOfService.MapMode.Dots; }
            set { }
        }
        public Microsoft.PointOfService.Rotation RotateSpecial
        {
            get { return Microsoft.PointOfService.Rotation.Normal; }
            set { }
        }
        public System.Int32 JrnLineChars
        {
            get { return 0; }
            set { }
        }
        public System.Int32[] JrnLineCharsList
        {
            get { return null; }
        }
        public System.Int32 JrnLineHeight
        {
            get { return 0; }
            set { }
        }
        public System.Int32 JrnLineSpacing
        {
            get { return 0; }
            set { }
        }
        public System.Int32 JrnLineWidth
        {
            get { return 0; }
        }
        public System.Boolean JrnLetterQuality
        {
            get { return false; }
            set { }
        }
        public System.Boolean JrnEmpty
        {
            get { return false; }
        }
        public System.Boolean JrnNearEnd
        {
            get { return false; }
        }
        public Microsoft.PointOfService.PrinterCartridgeStates JrnCartridgeState
        {
            get { return Microsoft.PointOfService.PrinterCartridgeStates.Unknown; }
        }
        public Microsoft.PointOfService.PrinterColors JrnCurrentCartridge
        {
            get { return Microsoft.PointOfService.PrinterColors.None; }
            set { }
        }
        public System.Int32 RecLineChars
        {
            get { return 0; }
            set { }
        }
        public System.Int32[] RecLineCharsList
        {
            get { return null; }
        }
        public System.Int32 RecLineHeight
        {
            get { return 0; }
            set { }
        }
        public System.Int32 RecLineSpacing
        {
            get { return 0; }
            set { }
        }
        public System.Int32 RecLineWidth
        {
            get { return 0; }
        }
        public System.Boolean RecLetterQuality
        {
            get { return false; }
            set { }
        }
        public System.Boolean RecEmpty
        {
            get { return false; }
        }
        public System.Boolean RecNearEnd
        {
            get { return false; }
        }
        public System.Int32 RecSidewaysMaxLines
        {
            get { return 0; }
        }
        public System.Int32 RecSidewaysMaxChars
        {
            get { return 0; }
        }
        public System.Int32 RecLinesToPaperCut
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.Rotation[] RecBarCodeRotationList
        {
            get { return null; }
        }
        public Microsoft.PointOfService.Rotation[] RecBitmapRotationList
        {
            get { return null; }
        }
        public Microsoft.PointOfService.PrinterCartridgeStates RecCartridgeState
        {
            get { return Microsoft.PointOfService.PrinterCartridgeStates.Unknown; }
        }
        public Microsoft.PointOfService.PrinterColors RecCurrentCartridge
        {
            get { return Microsoft.PointOfService.PrinterColors.None; }
            set { }
        }
        public System.Int32 SlpLineChars
        {
            get { return 0; }
            set { }
        }
        public System.Int32[] SlpLineCharsList
        {
            get { return null; }
        }
        public System.Int32 SlpLineHeight
        {
            get { return 0; }
            set { }
        }
        public System.Int32 SlpLineSpacing
        {
            get { return 0; }
            set { }
        }
        public System.Int32 SlpLineWidth
        {
            get { return 0; }
        }
        public System.Boolean SlpLetterQuality
        {
            get { return false; }
            set { }
        }
        public System.Boolean SlpEmpty
        {
            get { return false; }
        }
        public System.Boolean SlpNearEnd
        {
            get { return false; }
        }
        public System.Int32 SlpSidewaysMaxLines
        {
            get { return 0; }
        }
        public System.Int32 SlpSidewaysMaxChars
        {
            get { return 0; }
        }
        public System.Int32 SlpMaxLines
        {
            get { return 0; }
        }
        public System.Int32 SlpLinesNearEndToEnd
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.Rotation[] SlpBarCodeRotationList
        {
            get { return null; }
        }
        public Microsoft.PointOfService.Rotation[] SlpBitmapRotationList
        {
            get { return null; }
        }
        public Microsoft.PointOfService.PrinterSide SlpPrintSide
        {
            get { return Microsoft.PointOfService.PrinterSide.Unknown; }
        }
        public Microsoft.PointOfService.PrinterCartridgeStates SlpCartridgeState
        {
            get { return Microsoft.PointOfService.PrinterCartridgeStates.Unknown; }
        }
        public Microsoft.PointOfService.PrinterColors SlpCurrentCartridge
        {
            get { return Microsoft.PointOfService.PrinterColors.None; }
            set { }
        }
        public System.Boolean CapConcurrentPageMode
        {
            get { return false; }
        }
        public System.Boolean CapRecPageMode
        {
            get { return false; }
        }
        public System.Boolean CapSlpPageMode
        {
            get { return false; }
        }
        public System.Drawing.Point PageModeArea
        {
            get { return new System.Drawing.Point(); }
        }
        public Microsoft.PointOfService.PageModeDescriptors PageModeDescriptor
        {
            get { return Microsoft.PointOfService.PageModeDescriptors.None; }
        }
        public System.Int32 PageModeHorizontalPosition
        {
            get { return 0; }
            set { }
        }
        public System.Drawing.Rectangle PageModePrintArea
        {
            get { return new System.Drawing.Rectangle(); }
            set { }
        }
        public Microsoft.PointOfService.PageModePrintDirection PageModePrintDirection
        {
            get { return Microsoft.PointOfService.PageModePrintDirection.None; }
            set { }
        }
        public Microsoft.PointOfService.PrinterStation PageModeStation
        {
            get { return Microsoft.PointOfService.PrinterStation.None; }
            set { }
        }
        public System.Int32 PageModeVerticalPosition
        {
            get { return 0; }
            set { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.OutputCompleteEventHandler OutputCompleteEvent
        {
            add { }
            remove { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent
        {
            add { }
            remove { }
        }
        public virtual void ClearPrintArea()
        {
        }
        public virtual void PageModePrint(Microsoft.PointOfService.PageModePrintControl control)
        {
        }
        public virtual void BeginInsertion(System.Int32 timeout)
        {
        }
        public virtual void BeginRemoval(System.Int32 timeout)
        {
        }
        public virtual void ChangePrintSide(Microsoft.PointOfService.PrinterSide side)
        {
        }
        public virtual void CutPaper(System.Int32 percentage)
        {
        }
        public virtual void EndInsertion()
        {
        }
        public virtual void EndRemoval()
        {
        }
        public virtual void MarkFeed(Microsoft.PointOfService.PrinterMarkFeeds type)
        {
        }
        public virtual void PrintBarCode(Microsoft.PointOfService.PrinterStation station, System.String data, Microsoft.PointOfService.BarCodeSymbology symbology, System.Int32 height, System.Int32 width, System.Int32 alignment, Microsoft.PointOfService.BarCodeTextPosition textPosition)
        {
        }
        public virtual void PrintBitmap(Microsoft.PointOfService.PrinterStation station, System.String fileName, System.Int32 width, System.Int32 alignment)
        {
        }
        public virtual void PrintImmediate(Microsoft.PointOfService.PrinterStation station, System.String data)
        {
        }
        public virtual void PrintNormal(Microsoft.PointOfService.PrinterStation station, System.String data)
        {
        }
        public virtual void PrintTwoNormal(Microsoft.PointOfService.PrinterStation stations, System.String data1, System.String data2)
        {
        }
        public virtual void RotatePrint(Microsoft.PointOfService.PrinterStation station, Microsoft.PointOfService.PrintRotation rotation)
        {
        }
        public virtual void SetBitmap(System.Int32 bitmapNumber, Microsoft.PointOfService.PrinterStation station, System.String fileName, System.Int32 width, System.Int32 alignment)
        {
        }
        public virtual void SetLogo(Microsoft.PointOfService.PrinterLogoLocation location, System.String data)
        {
        }
        public virtual void TransactionPrint(Microsoft.PointOfService.PrinterStation station, Microsoft.PointOfService.PrinterTransactionControl control)
        {
        }
        public virtual void ValidateData(Microsoft.PointOfService.PrinterStation station, System.String data)
        {
        }
        public virtual void PrintMemoryBitmap(Microsoft.PointOfService.PrinterStation station, System.Drawing.Bitmap data, System.Int32 width, System.Int32 alignment)
        {
        }
        public virtual void ClearOutput()
        {
        }
    }
}
