namespace Microsoft.PointOfService
{
    public enum FiscalPrinterState
    {
        Monitor = 1,
        FiscalReceipt = 2,
        FiscalReceiptTotal = 3,
        FiscalReceiptEnding = 4,
        FiscalDocument = 5,
        FixedOutput = 6,
        ItemList = 7,
        Locked = 8,
        NonFiscal = 9,
        Report = 10,
    }
}
