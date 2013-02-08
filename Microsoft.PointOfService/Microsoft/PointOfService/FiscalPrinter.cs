namespace Microsoft.PointOfService
{
    public abstract class FiscalPrinter : Microsoft.PointOfService.PosCommon
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
        public abstract System.Int32 OutputId
        {
            get;
        }
        public abstract System.Boolean CapAdditionalHeader
        {
            get;
        }
        public abstract System.Boolean CapAdditionalLines
        {
            get;
        }
        public abstract System.Boolean CapAdditionalTrailer
        {
            get;
        }
        public abstract System.Boolean CapAmountAdjustment
        {
            get;
        }
        public abstract System.Boolean CapChangeDue
        {
            get;
        }
        public abstract System.Boolean CapCheckTotal
        {
            get;
        }
        public abstract System.Boolean CapCoverSensor
        {
            get;
        }
        public abstract System.Boolean CapDoubleWidth
        {
            get;
        }
        public abstract System.Boolean CapDuplicateReceipt
        {
            get;
        }
        public abstract System.Boolean CapEmptyReceiptIsVoidable
        {
            get;
        }
        public abstract System.Boolean CapFiscalReceiptStation
        {
            get;
        }
        public abstract System.Boolean CapFiscalReceiptType
        {
            get;
        }
        public abstract System.Boolean CapFixedOutput
        {
            get;
        }
        public abstract System.Boolean CapHasVatTable
        {
            get;
        }
        public abstract System.Boolean CapIndependentHeader
        {
            get;
        }
        public abstract System.Boolean CapItemList
        {
            get;
        }
        public abstract System.Boolean CapJrnEmptySensor
        {
            get;
        }
        public abstract System.Boolean CapJrnNearEndSensor
        {
            get;
        }
        public abstract System.Boolean CapJrnPresent
        {
            get;
        }
        public abstract System.Boolean CapMultiContractor
        {
            get;
        }
        public abstract System.Boolean CapNonFiscalMode
        {
            get;
        }
        public abstract System.Boolean CapOnlyVoidLastItem
        {
            get;
        }
        public abstract System.Boolean CapOrderAdjustmentFirst
        {
            get;
        }
        public abstract System.Boolean CapPackageAdjustment
        {
            get;
        }
        public abstract System.Boolean CapPercentAdjustment
        {
            get;
        }
        public abstract System.Boolean CapPositiveAdjustment
        {
            get;
        }
        public abstract System.Boolean CapPositiveSubtotalAdjustment
        {
            get;
        }
        public abstract System.Boolean CapPostPreLine
        {
            get;
        }
        public abstract System.Boolean CapPowerLossReport
        {
            get;
        }
        public abstract System.Boolean CapPredefinedPaymentLines
        {
            get;
        }
        public abstract System.Boolean CapReceiptNotPaid
        {
            get;
        }
        public abstract System.Boolean CapRecEmptySensor
        {
            get;
        }
        public abstract System.Boolean CapRecNearEndSensor
        {
            get;
        }
        public abstract System.Boolean CapRecPresent
        {
            get;
        }
        public abstract System.Boolean CapRemainingFiscalMemory
        {
            get;
        }
        public abstract System.Boolean CapReservedWord
        {
            get;
        }
        public abstract System.Boolean CapSetCurrency
        {
            get;
        }
        public abstract System.Boolean CapSetHeader
        {
            get;
        }
        public abstract System.Boolean CapSetPosId
        {
            get;
        }
        public abstract System.Boolean CapSetStoreFiscalId
        {
            get;
        }
        public abstract System.Boolean CapSetTrailer
        {
            get;
        }
        public abstract System.Boolean CapSetVatTable
        {
            get;
        }
        public abstract System.Boolean CapSlpEmptySensor
        {
            get;
        }
        public abstract System.Boolean CapSlpFiscalDocument
        {
            get;
        }
        public abstract System.Boolean CapSlpFullSlip
        {
            get;
        }
        public abstract System.Boolean CapSlpNearEndSensor
        {
            get;
        }
        public abstract System.Boolean CapSlpPresent
        {
            get;
        }
        public abstract System.Boolean CapSlpValidation
        {
            get;
        }
        public abstract System.Boolean CapSubAmountAdjustment
        {
            get;
        }
        public abstract System.Boolean CapSubPercentAdjustment
        {
            get;
        }
        public abstract System.Boolean CapSubtotal
        {
            get;
        }
        public abstract System.Boolean CapTotalizerType
        {
            get;
        }
        public abstract System.Boolean CapTrainingMode
        {
            get;
        }
        public abstract System.Boolean CapValidateJournal
        {
            get;
        }
        public abstract System.Boolean CapXReport
        {
            get;
        }
        public abstract Microsoft.PointOfService.FiscalCurrency ActualCurrency
        {
            get;
        }
        public abstract System.String AdditionalHeader
        {
            get;
            set;
        }
        public abstract System.String AdditionalTrailer
        {
            get;
            set;
        }
        public abstract System.Int32 AmountDecimalPlaces
        {
            get;
        }
        public abstract System.Boolean AsyncMode
        {
            get;
            set;
        }
        public abstract System.String ChangeDue
        {
            get;
            set;
        }
        public abstract System.Boolean CheckTotal
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.FiscalContractorId ContractorId
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.FiscalCountryCodes CountryCode
        {
            get;
        }
        public abstract System.Boolean CoverOpen
        {
            get;
        }
        public abstract Microsoft.PointOfService.FiscalDateType DateType
        {
            get;
            set;
        }
        public abstract System.Boolean DayOpened
        {
            get;
        }
        public abstract System.Int32 DescriptionLength
        {
            get;
        }
        public abstract System.Boolean DuplicateReceipt
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.FiscalErrorLevel ErrorLevel
        {
            get;
        }
        public abstract System.Int32 ErrorOutId
        {
            get;
        }
        public abstract Microsoft.PointOfService.FiscalPrinterState ErrorState
        {
            get;
        }
        public abstract Microsoft.PointOfService.FiscalPrinterStations ErrorStation
        {
            get;
        }
        public abstract System.String ErrorString
        {
            get;
        }
        public abstract Microsoft.PointOfService.FiscalReceiptStation FiscalReceiptStation
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.FiscalReceiptType FiscalReceiptType
        {
            get;
            set;
        }
        public abstract System.Boolean FlagWhenIdle
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
        public abstract System.Int32 MessageLength
        {
            get;
        }
        public abstract Microsoft.PointOfService.FiscalMessageType MessageType
        {
            get;
            set;
        }
        public abstract System.Int32 NumHeaderLines
        {
            get;
        }
        public abstract System.Int32 NumTrailerLines
        {
            get;
        }
        public abstract System.Int32 NumVatRates
        {
            get;
        }
        public abstract System.String PostLine
        {
            get;
            set;
        }
        public abstract System.String[] PredefinedPaymentLines
        {
            get;
        }
        public abstract System.String PreLine
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.FiscalPrinterState PrinterState
        {
            get;
        }
        public abstract System.Int32 QuantityDecimalPlaces
        {
            get;
        }
        public abstract System.Int32 QuantityLength
        {
            get;
        }
        public abstract System.Boolean RecEmpty
        {
            get;
        }
        public abstract System.Boolean RecNearEnd
        {
            get;
        }
        public abstract System.Int32 RemainingFiscalMemory
        {
            get;
        }
        public abstract System.String ReservedWord
        {
            get;
        }
        public abstract System.Boolean SlpEmpty
        {
            get;
        }
        public abstract System.Boolean SlpNearEnd
        {
            get;
        }
        public abstract Microsoft.PointOfService.FiscalSlipSelection SlipSelection
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.FiscalTotalizerType TotalizerType
        {
            get;
            set;
        }
        public abstract System.Boolean TrainingModeActive
        {
            get;
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
