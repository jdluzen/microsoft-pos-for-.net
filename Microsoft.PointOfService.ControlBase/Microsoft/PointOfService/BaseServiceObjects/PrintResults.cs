namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class PrintResults
    {
        public PrintResults()
        {
        }
        
        public Microsoft.PointOfService.PrinterStation PrinterStation { get { return Microsoft.PointOfService.PrinterStation.None; } set { } }
        public Microsoft.PointOfService.ErrorCode ErrorCode { get { return Microsoft.PointOfService.ErrorCode.Success; } set { } }
        public System.Int32 ErrorCodeExtended { get { return 0; } set { } }
        public System.String ErrorString { get { return null; } set { } }
        public Microsoft.PointOfService.PrinterErrorLevel ErrorLevel { get { return Microsoft.PointOfService.PrinterErrorLevel.None; } set { } }
        public System.Int32 BarcodePrintedCount { get { return 0; } set { } }
        public System.Int32 FailedPaperCutCount { get { return 0; } set { } }
        public System.Int32 FailedPrintSideChangeCount { get { return 0; } set { } }
        public System.Int32 FormInsertionCount { get { return 0; } set { } }
        public System.Int32 HomeErrorCount { get { return 0; } set { } }
        public System.Int32 JournalCharacterPrintedCount { get { return 0; } set { } }
        public System.Int32 JournalLinePrintedCount { get { return 0; } set { } }
        public System.Int32 MaximumTempReachedCount { get { return 0; } set { } }
        public System.Int32 NVRAMWriteCount { get { return 0; } set { } }
        public System.Int32 PaperCutCount { get { return 0; } set { } }
        public System.Int32 PrinterFaultCount { get { return 0; } set { } }
        public System.Int32 PrintSideChangeCount { get { return 0; } set { } }
        public System.Int32 ReceiptCharacterPrintedCount { get { return 0; } set { } }
        public System.Int32 ReceiptLineFeedCount { get { return 0; } set { } }
        public System.Int32 ReceiptLinePrintedCount { get { return 0; } set { } }
        public System.Int32 SlipCharacterPrintedCount { get { return 0; } set { } }
        public System.Int32 SlipLineFeedCount { get { return 0; } set { } }
        public System.Int32 SlipLinePrintedCount { get { return 0; } set { } }
        public System.Int32 StampFiredCount { get { return 0; } set { } }
    }
}
