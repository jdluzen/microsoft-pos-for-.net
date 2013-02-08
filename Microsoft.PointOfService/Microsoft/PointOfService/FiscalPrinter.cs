namespace Microsoft.PointOfService
{
    public class FiscalPrinter : Microsoft.PointOfService.PosCommon
    {
        protected FiscalPrinter()
        {
        }
        public const System.Int32 PaymentDescriptionCash = 1;
        public const System.Int32 PaymentDescriptionCheque = 2;
        public const System.Int32 PaymentDescriptionChitty = 3;
        public const System.Int32 PaymentDescriptionCoupon = 4;
        public const System.Int32 PaymentDescriptionCurrency = 5;
        public const System.Int32 PaymentDescriptionDrivenOff = 6;
        public const System.Int32 PaymentDescriptionEftImprinter = 7;
        public const System.Int32 PaymentDescriptionEftTerminal = 8;
        public const System.Int32 PaymentDescriptionTerminalImprinter = 9;
        public const System.Int32 PaymentDescriptionFreeGift = 10;
        public const System.Int32 PaymentDescriptionGiro = 11;
        public const System.Int32 PaymentDescriptionHome = 12;
        public const System.Int32 PaymentDescriptionImprinterWithIssuer = 13;
        public const System.Int32 PaymentDescriptionLocalAccount = 14;
        public const System.Int32 PaymentDescriptionLocalAccountCard = 15;
        public const System.Int32 PaymentDescriptionPayCard = 16;
        public const System.Int32 PaymentDescriptionPayCardManual = 17;
        public const System.Int32 PaymentDescriptionPrepay = 18;
        public const System.Int32 PaymentDescriptionPumpTest = 19;
        public const System.Int32 PaymentDescriptionShortCredit = 20;
        public const System.Int32 PaymentDescriptionStaff = 21;
        public const System.Int32 PaymentDescriptionVoucher = 22;
        public const System.Int32 LineCountItem = 1;
        public const System.Int32 LineCountItemVoid = 2;
        public const System.Int32 LineCountDiscount = 3;
        public const System.Int32 LineCountDiscountVoid = 4;
        public const System.Int32 LineCountSurcharge = 5;
        public const System.Int32 LineCountSurchargeVoid = 6;
        public const System.Int32 LineCountRefund = 7;
        public const System.Int32 LineCountRefundVoid = 8;
        public const System.Int32 LineCountSubtotalDiscount = 9;
        public const System.Int32 LineCountSubtotalDiscountVoid = 10;
        public const System.Int32 LineCountSubtotalSurcharge = 11;
        public const System.Int32 LineCountSubtotalSurchargeVoid = 12;
        public const System.Int32 LineCountComment = 13;
        public const System.Int32 LineCountSubtotal = 14;
        public const System.Int32 LineCountTotal = 15;
        public const System.Int32 DescriptionLengthItem = 1;
        public const System.Int32 DescriptionLengthItemAdjustment = 2;
        public const System.Int32 DescriptionLengthItemFuel = 3;
        public const System.Int32 DescriptionLengthItemFuelVoid = 4;
        public const System.Int32 DescriptionLengthNotPaid = 5;
        public const System.Int32 DescriptionLengthPackageAdjustment = 6;
        public const System.Int32 DescriptionLengthRefund = 7;
        public const System.Int32 DescriptionLengthRefundVoid = 8;
        public const System.Int32 DescriptionLengthSubtotalAdjustment = 9;
        public const System.Int32 DescriptionLengthTotal = 10;
        public const System.Int32 DescriptionLengthVoid = 11;
        public const System.Int32 DescriptionLengthVoidItem = 12;
        public const System.Int32 CurrencyEuro = 1;
        public const System.Int32 ExtendedErrorCoverOpen = 201;
        public const System.Int32 ExtendedErrorJournalEmpty = 202;
        public const System.Int32 ExtendedErrorReceiptEmpty = 203;
        public const System.Int32 ExtendedErrorSlipEmpty = 204;
        public const System.Int32 ExtendedErrorSlipForm = 205;
        public const System.Int32 ExtendedErrorMissingDevices = 206;
        public const System.Int32 ExtendedErrorWrongState = 207;
        public const System.Int32 ExtendedErrorTechnicalAssistance = 208;
        public const System.Int32 ExtendedErrorClockError = 209;
        public const System.Int32 ExtendedErrorMemoryFull = 210;
        public const System.Int32 ExtendedErrorMemoryDisconnected = 211;
        public const System.Int32 ExtendedErrorTotalsError = 212;
        public const System.Int32 ExtendedErrorBadItemQuantity = 213;
        public const System.Int32 ExtendedErrorBadItemAmount = 214;
        public const System.Int32 ExtendedErrorBadItemDescription = 215;
        public const System.Int32 ExtendedErrorReceiptTotalOverflow = 216;
        public const System.Int32 ExtendedErrorBadVat = 217;
        public const System.Int32 ExtendedErrorBadPrice = 218;
        public const System.Int32 ExtendedErrorBadDate = 219;
        public const System.Int32 ExtendedErrorNegativeTotal = 220;
        public const System.Int32 ExtendedErrorWordNotAllowed = 221;
        public const System.Int32 ExtendedErrorBadLength = 222;
        public const System.Int32 ExtendedErrorMissingSetCurrency = 223;
        public const System.Int32 ExtendedErrorDayEndRequired = 224;
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
        public const System.Int32 StatusJournalCoverOpen = 60;
        public const System.Int32 StatusJournalCoverOK = 61;
        public const System.Int32 StatusReceiptCoverOpen = 62;
        public const System.Int32 StatusReceiptCoverOK = 63;
        public const System.Int32 StatusSlipCoverOpen = 64;
        public const System.Int32 StatusSlipCoverOK = 65;
        public const System.Int32 StatusIdle = 1001;
        public System.Int32 OutputId
        {
            get { return 0; }
        }
        public System.Boolean CapAdditionalHeader
        {
            get { return false; }
        }
        public System.Boolean CapAdditionalLines
        {
            get { return false; }
        }
        public System.Boolean CapAdditionalTrailer
        {
            get { return false; }
        }
        public System.Boolean CapAmountAdjustment
        {
            get { return false; }
        }
        public System.Boolean CapChangeDue
        {
            get { return false; }
        }
        public System.Boolean CapCheckTotal
        {
            get { return false; }
        }
        public System.Boolean CapCoverSensor
        {
            get { return false; }
        }
        public System.Boolean CapDoubleWidth
        {
            get { return false; }
        }
        public System.Boolean CapDuplicateReceipt
        {
            get { return false; }
        }
        public System.Boolean CapEmptyReceiptIsVoidable
        {
            get { return false; }
        }
        public System.Boolean CapFiscalReceiptStation
        {
            get { return false; }
        }
        public System.Boolean CapFiscalReceiptType
        {
            get { return false; }
        }
        public System.Boolean CapFixedOutput
        {
            get { return false; }
        }
        public System.Boolean CapHasVatTable
        {
            get { return false; }
        }
        public System.Boolean CapIndependentHeader
        {
            get { return false; }
        }
        public System.Boolean CapItemList
        {
            get { return false; }
        }
        public System.Boolean CapJrnEmptySensor
        {
            get { return false; }
        }
        public System.Boolean CapJrnNearEndSensor
        {
            get { return false; }
        }
        public System.Boolean CapJrnPresent
        {
            get { return false; }
        }
        public System.Boolean CapMultiContractor
        {
            get { return false; }
        }
        public System.Boolean CapNonFiscalMode
        {
            get { return false; }
        }
        public System.Boolean CapOnlyVoidLastItem
        {
            get { return false; }
        }
        public System.Boolean CapOrderAdjustmentFirst
        {
            get { return false; }
        }
        public System.Boolean CapPackageAdjustment
        {
            get { return false; }
        }
        public System.Boolean CapPercentAdjustment
        {
            get { return false; }
        }
        public System.Boolean CapPositiveAdjustment
        {
            get { return false; }
        }
        public System.Boolean CapPositiveSubtotalAdjustment
        {
            get { return false; }
        }
        public System.Boolean CapPostPreLine
        {
            get { return false; }
        }
        public System.Boolean CapPowerLossReport
        {
            get { return false; }
        }
        public System.Boolean CapPredefinedPaymentLines
        {
            get { return false; }
        }
        public System.Boolean CapReceiptNotPaid
        {
            get { return false; }
        }
        public System.Boolean CapRecEmptySensor
        {
            get { return false; }
        }
        public System.Boolean CapRecNearEndSensor
        {
            get { return false; }
        }
        public System.Boolean CapRecPresent
        {
            get { return false; }
        }
        public System.Boolean CapRemainingFiscalMemory
        {
            get { return false; }
        }
        public System.Boolean CapReservedWord
        {
            get { return false; }
        }
        public System.Boolean CapSetCurrency
        {
            get { return false; }
        }
        public System.Boolean CapSetHeader
        {
            get { return false; }
        }
        public System.Boolean CapSetPosId
        {
            get { return false; }
        }
        public System.Boolean CapSetStoreFiscalId
        {
            get { return false; }
        }
        public System.Boolean CapSetTrailer
        {
            get { return false; }
        }
        public System.Boolean CapSetVatTable
        {
            get { return false; }
        }
        public System.Boolean CapSlpEmptySensor
        {
            get { return false; }
        }
        public System.Boolean CapSlpFiscalDocument
        {
            get { return false; }
        }
        public System.Boolean CapSlpFullSlip
        {
            get { return false; }
        }
        public System.Boolean CapSlpNearEndSensor
        {
            get { return false; }
        }
        public System.Boolean CapSlpPresent
        {
            get { return false; }
        }
        public System.Boolean CapSlpValidation
        {
            get { return false; }
        }
        public System.Boolean CapSubAmountAdjustment
        {
            get { return false; }
        }
        public System.Boolean CapSubPercentAdjustment
        {
            get { return false; }
        }
        public System.Boolean CapSubtotal
        {
            get { return false; }
        }
        public System.Boolean CapTotalizerType
        {
            get { return false; }
        }
        public System.Boolean CapTrainingMode
        {
            get { return false; }
        }
        public System.Boolean CapValidateJournal
        {
            get { return false; }
        }
        public System.Boolean CapXReport
        {
            get { return false; }
        }
        public Microsoft.PointOfService.FiscalCurrency ActualCurrency
        {
            get { return Microsoft.PointOfService.FiscalCurrency.BrazilianCruceiro; }
        }
        public System.String AdditionalHeader
        {
            get { return null; }
            set { }
        }
        public System.String AdditionalTrailer
        {
            get { return null; }
            set { }
        }
        public System.Int32 AmountDecimalPlaces
        {
            get { return 0; }
        }
        public System.Boolean AsyncMode
        {
            get { return false; }
            set { }
        }
        public System.String ChangeDue
        {
            get { return null; }
            set { }
        }
        public System.Boolean CheckTotal
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.FiscalContractorId ContractorId
        {
            get { return Microsoft.PointOfService.FiscalContractorId.First; }
            set { }
        }
        public Microsoft.PointOfService.FiscalCountryCodes CountryCode
        {
            get { return Microsoft.PointOfService.FiscalCountryCodes.Brazil; }
        }
        public System.Boolean CoverOpen
        {
            get { return false; }
        }
        public Microsoft.PointOfService.FiscalDateType DateType
        {
            get { return Microsoft.PointOfService.FiscalDateType.Configuration; }
            set { }
        }
        public System.Boolean DayOpened
        {
            get { return false; }
        }
        public System.Int32 DescriptionLength
        {
            get { return 0; }
        }
        public System.Boolean DuplicateReceipt
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.FiscalErrorLevel ErrorLevel
        {
            get { return Microsoft.PointOfService.FiscalErrorLevel.None; }
        }
        public System.Int32 ErrorOutId
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.FiscalPrinterState ErrorState
        {
            get { return Microsoft.PointOfService.FiscalPrinterState.Monitor; }
        }
        public Microsoft.PointOfService.FiscalPrinterStations ErrorStation
        {
            get { return Microsoft.PointOfService.FiscalPrinterStations.Journal; }
        }
        public System.String ErrorString
        {
            get { return null; }
        }
        public Microsoft.PointOfService.FiscalReceiptStation FiscalReceiptStation
        {
            get { return Microsoft.PointOfService.FiscalReceiptStation.Receipt; }
            set { }
        }
        public Microsoft.PointOfService.FiscalReceiptType FiscalReceiptType
        {
            get { return Microsoft.PointOfService.FiscalReceiptType.CashIn; }
            set { }
        }
        public System.Boolean FlagWhenIdle
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
        public System.Int32 MessageLength
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.FiscalMessageType MessageType
        {
            get { return Microsoft.PointOfService.FiscalMessageType.Advance; }
            set { }
        }
        public System.Int32 NumHeaderLines
        {
            get { return 0; }
        }
        public System.Int32 NumTrailerLines
        {
            get { return 0; }
        }
        public System.Int32 NumVatRates
        {
            get { return 0; }
        }
        public System.String PostLine
        {
            get { return null; }
            set { }
        }
        public System.String[] PredefinedPaymentLines
        {
            get { return null; }
        }
        public System.String PreLine
        {
            get { return null; }
            set { }
        }
        public Microsoft.PointOfService.FiscalPrinterState PrinterState
        {
            get { return Microsoft.PointOfService.FiscalPrinterState.Monitor; }
        }
        public System.Int32 QuantityDecimalPlaces
        {
            get { return 0; }
        }
        public System.Int32 QuantityLength
        {
            get { return 0; }
        }
        public System.Boolean RecEmpty
        {
            get { return false; }
        }
        public System.Boolean RecNearEnd
        {
            get { return false; }
        }
        public System.Int32 RemainingFiscalMemory
        {
            get { return 0; }
        }
        public System.String ReservedWord
        {
            get { return null; }
        }
        public System.Boolean SlpEmpty
        {
            get { return false; }
        }
        public System.Boolean SlpNearEnd
        {
            get { return false; }
        }
        public Microsoft.PointOfService.FiscalSlipSelection SlipSelection
        {
            get { return Microsoft.PointOfService.FiscalSlipSelection.FullLength; }
            set { }
        }
        public Microsoft.PointOfService.FiscalTotalizerType TotalizerType
        {
            get { return Microsoft.PointOfService.FiscalTotalizerType.Document; }
            set { }
        }
        public System.Boolean TrainingModeActive
        {
            get { return false; }
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
        public virtual void BeginRemoval(System.Int32 timeout)
        {
        }
        public virtual void BeginTraining()
        {
        }
        public virtual void ClearError()
        {
        }
        public virtual void EndFiscalDocument()
        {
        }
        public virtual void EndFiscalReceipt(System.Boolean printHeader)
        {
        }
        public virtual void EndFixedOutput()
        {
        }
        public virtual void EndInsertion()
        {
        }
        public virtual void EndItemList()
        {
        }
        public virtual void EndNonFiscal()
        {
        }
        public virtual void EndRemoval()
        {
        }
        public virtual void EndTraining()
        {
        }
        public virtual Microsoft.PointOfService.FiscalDataItem GetData(Microsoft.PointOfService.FiscalData dataItem, System.Int32 optArgs)
        {
            return new Microsoft.PointOfService.FiscalDataItem();
        }
        public virtual System.DateTime GetDate()
        {
            return new System.DateTime();
        }
        public virtual System.String GetTotalizer(System.Int32 vatId, Microsoft.PointOfService.FiscalTotalizer optArgs)
        {
            return null;
        }
        public virtual System.Int32 GetVatEntry(System.Int32 vatId, System.Int32 optArgs)
        {
            return 0;
        }
        public virtual void PrintDuplicateReceipt()
        {
        }
        public virtual void PrintFiscalDocumentLine(System.String documentLine)
        {
        }
        public virtual void PrintFixedOutput(System.Int32 documentType, System.Int32 lineNumber, System.String data)
        {
        }
        public virtual void PrintNormal(Microsoft.PointOfService.FiscalPrinterStations station, System.String data)
        {
        }
        public virtual void PrintPeriodicTotalsReport(System.DateTime startingDate, System.DateTime endingDate)
        {
        }
        public virtual void PrintPowerLossReport()
        {
        }
        public virtual void PrintRecCash(System.Decimal amount)
        {
        }
        public virtual void PrintRecItem(System.String description, System.Decimal price, System.Int32 quantity, System.Int32 vatInfo, System.Decimal unitPrice, System.String unitName)
        {
        }
        public virtual void PrintRecItemAdjustment(Microsoft.PointOfService.FiscalAdjustment adjustmentType, System.String description, System.Decimal amount, System.Int32 vatInfo)
        {
        }
        public virtual void PrintRecItemAdjustmentVoid(Microsoft.PointOfService.FiscalAdjustment adjustmentType, System.String description, System.Decimal amount, System.Int32 vatInfo)
        {
        }
        public virtual void PrintRecItemFuel(System.String description, System.Decimal price, System.Int32 quantity, System.Int32 vatInfo, System.Decimal unitPrice, System.String unitName, System.Decimal specialTax, System.String specialTaxName)
        {
        }
        public virtual void PrintRecItemFuelVoid(System.String description, System.Decimal price, System.Int32 vatInfo, System.Decimal specialTax)
        {
        }
        public virtual void PrintRecItemVoid(System.String description, System.Decimal price, System.Int32 quantity, System.Int32 vatInfo, System.Decimal unitPrice, System.String unitName)
        {
        }
        public virtual void PrintRecMessage(System.String message)
        {
        }
        public virtual void PrintRecNotPaid(System.String description, System.Decimal amount)
        {
        }
        public virtual void PrintRecPackageAdjustment(Microsoft.PointOfService.FiscalAdjustmentType adjustmentType, System.String description, System.Collections.Generic.IEnumerable<Microsoft.PointOfService.VatInfo> vatAdjustments)
        {
        }
        public virtual void PrintRecPackageAdjustVoid(Microsoft.PointOfService.FiscalAdjustmentType adjustmentType, System.Collections.Generic.IEnumerable<Microsoft.PointOfService.VatInfo> vatAdjustments)
        {
        }
        public virtual void PrintRecRefund(System.String description, System.Decimal amount, System.Int32 vatInfo)
        {
        }
        public virtual void PrintRecRefundVoid(System.String description, System.Decimal amount, System.Int32 vatInfo)
        {
        }
        public virtual void PrintRecSubtotal(System.Decimal amount)
        {
        }
        public virtual void PrintRecSubtotalAdjustment(Microsoft.PointOfService.FiscalAdjustment adjustmentType, System.String description, System.Decimal amount)
        {
        }
        public virtual void PrintRecSubtotalAdjustVoid(Microsoft.PointOfService.FiscalAdjustment adjustmentType, System.Decimal amount)
        {
        }
        public virtual void PrintRecTaxId(System.String taxId)
        {
        }
        public virtual void PrintRecTotal(System.Decimal total, System.Decimal payment, System.String description)
        {
        }
        public virtual void PrintRecVoid(System.String description)
        {
        }
        public virtual void PrintReport(Microsoft.PointOfService.ReportType reportType, System.String startNum, System.String endNum)
        {
        }
        public virtual void PrintXReport()
        {
        }
        public virtual void PrintZReport()
        {
        }
        public virtual void ResetPrinter()
        {
        }
        public virtual void SetCurrency(Microsoft.PointOfService.FiscalCurrency newCurrency)
        {
        }
        public virtual void SetDate(System.DateTime newDate)
        {
        }
        public virtual void SetHeaderLine(System.Int32 lineNumber, System.String text, System.Boolean doubleWidth)
        {
        }
        public virtual void SetPosId(System.String posId, System.String cashierId)
        {
        }
        public virtual void SetStoreFiscalId(System.String id)
        {
        }
        public virtual void SetTrailerLine(System.Int32 lineNumber, System.String text, System.Boolean doubleWidth)
        {
        }
        public virtual void SetVatTable()
        {
        }
        public virtual void SetVatValue(System.Int32 vatId, System.String vatValue)
        {
        }
        public virtual void VerifyItem(System.String itemName, System.Int32 vatId)
        {
        }
        public virtual void PrintRecItemRefund(System.String description, System.Decimal amount, System.Int32 quantity, System.Int32 vatInfo, System.Decimal unitAmount, System.String unitName)
        {
        }
        public virtual void PrintRecItemRefundVoid(System.String description, System.Decimal amount, System.Int32 quantity, System.Int32 vatInfo, System.Decimal unitAmount, System.String unitName)
        {
        }
        public virtual void ClearOutput()
        {
        }
        public virtual void BeginFiscalDocument(System.Int32 documentAmount)
        {
        }
        public virtual void BeginFiscalReceipt(System.Boolean printHeader)
        {
        }
        public virtual void BeginFixedOutput(Microsoft.PointOfService.FiscalReceiptStation station, System.Int32 documentType)
        {
        }
        public virtual void BeginInsertion(System.Int32 timeout)
        {
        }
        public virtual void BeginItemList(System.Int32 vatId)
        {
        }
        public virtual void BeginNonFiscal()
        {
        }
    }
}
