namespace Microsoft.PointOfService
{
    public abstract class PosPrinter : Microsoft.PointOfService.PosCommon
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
        public abstract System.Int32 OutputId
        {
            get;
        }
        public abstract Microsoft.PointOfService.CharacterSetCapability CapCharacterSet
        {
            get;
        }
        public abstract System.Boolean CapConcurrentJrnRec
        {
            get;
        }
        public abstract System.Boolean CapConcurrentJrnSlp
        {
            get;
        }
        public abstract System.Boolean CapConcurrentRecSlp
        {
            get;
        }
        public abstract System.Boolean CapCoverSensor
        {
            get;
        }
        public abstract System.Boolean CapMapCharacterSet
        {
            get;
        }
        public abstract System.Boolean CapTransaction
        {
            get;
        }
        public abstract System.Boolean CapJrnPresent
        {
            get;
        }
        public abstract System.Boolean CapJrn2Color
        {
            get;
        }
        public abstract System.Boolean CapJrnBold
        {
            get;
        }
        public abstract System.Boolean CapJrnDHigh
        {
            get;
        }
        public abstract System.Boolean CapJrnDWide
        {
            get;
        }
        public abstract System.Boolean CapJrnDWideDHigh
        {
            get;
        }
        public abstract System.Boolean CapJrnEmptySensor
        {
            get;
        }
        public abstract System.Boolean CapJrnItalic
        {
            get;
        }
        public abstract System.Boolean CapJrnNearEndSensor
        {
            get;
        }
        public abstract System.Boolean CapJrnUnderline
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterCartridgeSensors CapJrnCartridgeSensor
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterColors CapJrnColor
        {
            get;
        }
        public abstract System.Boolean CapRecPresent
        {
            get;
        }
        public abstract System.Boolean CapRec2Color
        {
            get;
        }
        public abstract System.Boolean CapRecBarCode
        {
            get;
        }
        public abstract System.Boolean CapRecBitmap
        {
            get;
        }
        public abstract System.Boolean CapRecBold
        {
            get;
        }
        public abstract System.Boolean CapRecDHigh
        {
            get;
        }
        public abstract System.Boolean CapRecDWide
        {
            get;
        }
        public abstract System.Boolean CapRecDWideDHigh
        {
            get;
        }
        public abstract System.Boolean CapRecEmptySensor
        {
            get;
        }
        public abstract System.Boolean CapRecItalic
        {
            get;
        }
        public abstract System.Boolean CapRecLeft90
        {
            get;
        }
        public abstract System.Boolean CapRecNearEndSensor
        {
            get;
        }
        public abstract System.Boolean CapRecPaperCut
        {
            get;
        }
        public abstract System.Boolean CapRecRight90
        {
            get;
        }
        public abstract System.Boolean CapRecRotate180
        {
            get;
        }
        public abstract System.Boolean CapRecStamp
        {
            get;
        }
        public abstract System.Boolean CapRecUnderline
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterCartridgeSensors CapRecCartridgeSensor
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterColors CapRecColor
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterMarkFeeds CapRecMarkFeed
        {
            get;
        }
        public abstract System.Boolean CapSlpPresent
        {
            get;
        }
        public abstract System.Boolean CapSlpFullSlip
        {
            get;
        }
        public abstract System.Boolean CapSlp2Color
        {
            get;
        }
        public abstract System.Boolean CapSlpBarCode
        {
            get;
        }
        public abstract System.Boolean CapSlpBitmap
        {
            get;
        }
        public abstract System.Boolean CapSlpBold
        {
            get;
        }
        public abstract System.Boolean CapSlpDHigh
        {
            get;
        }
        public abstract System.Boolean CapSlpDWide
        {
            get;
        }
        public abstract System.Boolean CapSlpDWideDHigh
        {
            get;
        }
        public abstract System.Boolean CapSlpEmptySensor
        {
            get;
        }
        public abstract System.Boolean CapSlpItalic
        {
            get;
        }
        public abstract System.Boolean CapSlpLeft90
        {
            get;
        }
        public abstract System.Boolean CapSlpNearEndSensor
        {
            get;
        }
        public abstract System.Boolean CapSlpRight90
        {
            get;
        }
        public abstract System.Boolean CapSlpRotate180
        {
            get;
        }
        public abstract System.Boolean CapSlpUnderline
        {
            get;
        }
        public abstract System.Boolean CapSlpBothSidesPrint
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterCartridgeSensors CapSlpCartridgeSensor
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterColors CapSlpColor
        {
            get;
        }
        public abstract System.Boolean AsyncMode
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.PrinterCartridgeNotify CartridgeNotify
        {
            get;
            set;
        }
        public abstract System.Int32 CharacterSet
        {
            get;
            set;
        }
        public abstract System.Int32[] CharacterSetList
        {
            get;
        }
        public abstract System.Boolean CoverOpen
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterErrorLevel ErrorLevel
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterStation ErrorStation
        {
            get;
        }
        public abstract System.String ErrorString
        {
            get;
        }
        public abstract System.String[] FontTypefaceList
        {
            get;
        }
        public abstract System.Boolean FlagWhenIdle
        {
            get;
            set;
        }
        public abstract System.Boolean MapCharacterSet
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.MapMode MapMode
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.Rotation RotateSpecial
        {
            get;
            set;
        }
        public abstract System.Int32 JrnLineChars
        {
            get;
            set;
        }
        public abstract System.Int32[] JrnLineCharsList
        {
            get;
        }
        public abstract System.Int32 JrnLineHeight
        {
            get;
            set;
        }
        public abstract System.Int32 JrnLineSpacing
        {
            get;
            set;
        }
        public abstract System.Int32 JrnLineWidth
        {
            get;
        }
        public abstract System.Boolean JrnLetterQuality
        {
            get;
            set;
        }
        public abstract System.Boolean JrnEmpty
        {
            get;
        }
        public abstract System.Boolean JrnNearEnd
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterCartridgeStates JrnCartridgeState
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterColors JrnCurrentCartridge
        {
            get;
            set;
        }
        public abstract System.Int32 RecLineChars
        {
            get;
            set;
        }
        public abstract System.Int32[] RecLineCharsList
        {
            get;
        }
        public abstract System.Int32 RecLineHeight
        {
            get;
            set;
        }
        public abstract System.Int32 RecLineSpacing
        {
            get;
            set;
        }
        public abstract System.Int32 RecLineWidth
        {
            get;
        }
        public abstract System.Boolean RecLetterQuality
        {
            get;
            set;
        }
        public abstract System.Boolean RecEmpty
        {
            get;
        }
        public abstract System.Boolean RecNearEnd
        {
            get;
        }
        public abstract System.Int32 RecSidewaysMaxLines
        {
            get;
        }
        public abstract System.Int32 RecSidewaysMaxChars
        {
            get;
        }
        public abstract System.Int32 RecLinesToPaperCut
        {
            get;
        }
        public abstract Microsoft.PointOfService.Rotation[] RecBarCodeRotationList
        {
            get;
        }
        public abstract Microsoft.PointOfService.Rotation[] RecBitmapRotationList
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterCartridgeStates RecCartridgeState
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterColors RecCurrentCartridge
        {
            get;
            set;
        }
        public abstract System.Int32 SlpLineChars
        {
            get;
            set;
        }
        public abstract System.Int32[] SlpLineCharsList
        {
            get;
        }
        public abstract System.Int32 SlpLineHeight
        {
            get;
            set;
        }
        public abstract System.Int32 SlpLineSpacing
        {
            get;
            set;
        }
        public abstract System.Int32 SlpLineWidth
        {
            get;
        }
        public abstract System.Boolean SlpLetterQuality
        {
            get;
            set;
        }
        public abstract System.Boolean SlpEmpty
        {
            get;
        }
        public abstract System.Boolean SlpNearEnd
        {
            get;
        }
        public abstract System.Int32 SlpSidewaysMaxLines
        {
            get;
        }
        public abstract System.Int32 SlpSidewaysMaxChars
        {
            get;
        }
        public abstract System.Int32 SlpMaxLines
        {
            get;
        }
        public abstract System.Int32 SlpLinesNearEndToEnd
        {
            get;
        }
        public abstract Microsoft.PointOfService.Rotation[] SlpBarCodeRotationList
        {
            get;
        }
        public abstract Microsoft.PointOfService.Rotation[] SlpBitmapRotationList
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterSide SlpPrintSide
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterCartridgeStates SlpCartridgeState
        {
            get;
        }
        public abstract Microsoft.PointOfService.PrinterColors SlpCurrentCartridge
        {
            get;
            set;
        }
        public virtual System.Boolean CapConcurrentPageMode
        {
            get { return false; }
        }
        public virtual System.Boolean CapRecPageMode
        {
            get { return false; }
        }
        public virtual System.Boolean CapSlpPageMode
        {
            get { return false; }
        }
        public virtual System.Drawing.Point PageModeArea
        {
            get { return new System.Drawing.Point(); }
        }
        public virtual Microsoft.PointOfService.PageModeDescriptors PageModeDescriptor
        {
            get { return Microsoft.PointOfService.PageModeDescriptors.None; }
        }
        public virtual System.Int32 PageModeHorizontalPosition
        {
            get { return 0; }
            set { }
        }
        public virtual System.Drawing.Rectangle PageModePrintArea
        {
            get { return new System.Drawing.Rectangle(); }
            set { }
        }
        public virtual Microsoft.PointOfService.PageModePrintDirection PageModePrintDirection
        {
            get { return Microsoft.PointOfService.PageModePrintDirection.None; }
            set { }
        }
        public virtual Microsoft.PointOfService.PrinterStation PageModeStation
        {
            get { return Microsoft.PointOfService.PrinterStation.None; }
            set { }
        }
        public virtual System.Int32 PageModeVerticalPosition
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
