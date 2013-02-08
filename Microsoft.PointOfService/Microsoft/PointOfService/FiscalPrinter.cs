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
        public virtual void BeginRemoval(System.Int32 param_param_timeout)
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
        public virtual void EndFiscalReceipt(System.Boolean param_param_printHeader)
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
        public virtual Microsoft.PointOfService.FiscalDataItem GetData(Microsoft.PointOfService.FiscalData param_param_dataItem, System.Int32 param_param_optArgs)
        {
            return new Microsoft.PointOfService.FiscalDataItem();
        }
        public virtual System.DateTime GetDate()
        {
            return new System.DateTime();
        }
        public virtual System.String GetTotalizer(System.Int32 param_param_vatId, Microsoft.PointOfService.FiscalTotalizer param_param_optArgs)
        {
            return null;
        }
        public virtual System.Int32 GetVatEntry(System.Int32 param_param_vatId, System.Int32 param_param_optArgs)
        {
            return 0;
        }
        public virtual void PrintDuplicateReceipt()
        {
        }
        public virtual void PrintFiscalDocumentLine(System.String param_param_documentLine)
        {
        }
        public virtual void PrintFixedOutput(System.Int32 param_param_documentType, System.Int32 param_param_lineNumber, System.String param_param_data)
        {
        }
        public virtual void PrintNormal(Microsoft.PointOfService.FiscalPrinterStations param_param_station, System.String param_param_data)
        {
        }
        public virtual void PrintPeriodicTotalsReport(System.DateTime param_param_startingDate, System.DateTime param_param_endingDate)
        {
        }
        public virtual void PrintPowerLossReport()
        {
        }
        public virtual void PrintRecCash(System.Decimal param_param_amount)
        {
        }
        public virtual void PrintRecItem(System.String param_param_description, System.Decimal param_param_price, System.Int32 param_param_quantity, System.Int32 param_param_vatInfo, System.Decimal param_param_unitPrice, System.String param_param_unitName)
        {
        }
        public virtual void PrintRecItemAdjustment(Microsoft.PointOfService.FiscalAdjustment param_param_adjustmentType, System.String param_param_description, System.Decimal param_param_amount, System.Int32 param_param_vatInfo)
        {
        }
        public virtual void PrintRecItemAdjustmentVoid(Microsoft.PointOfService.FiscalAdjustment param_param_adjustmentType, System.String param_param_description, System.Decimal param_param_amount, System.Int32 param_param_vatInfo)
        {
        }
        public virtual void PrintRecItemFuel(System.String param_param_description, System.Decimal param_param_price, System.Int32 param_param_quantity, System.Int32 param_param_vatInfo, System.Decimal param_param_unitPrice, System.String param_param_unitName, System.Decimal param_param_specialTax, System.String param_param_specialTaxName)
        {
        }
        public virtual void PrintRecItemFuelVoid(System.String param_param_description, System.Decimal param_param_price, System.Int32 param_param_vatInfo, System.Decimal param_param_specialTax)
        {
        }
        public virtual void PrintRecItemVoid(System.String param_param_description, System.Decimal param_param_price, System.Int32 param_param_quantity, System.Int32 param_param_vatInfo, System.Decimal param_param_unitPrice, System.String param_param_unitName)
        {
        }
        public virtual void PrintRecMessage(System.String param_param_message)
        {
        }
        public virtual void PrintRecNotPaid(System.String param_param_description, System.Decimal param_param_amount)
        {
        }
        public virtual void PrintRecPackageAdjustment(Microsoft.PointOfService.FiscalAdjustmentType param_param_adjustmentType, System.String param_param_description, System.Collections.Generic.IEnumerable<Microsoft.PointOfService.VatInfo> param_param_vatAdjustments)
        {
        }
        public virtual void PrintRecPackageAdjustVoid(Microsoft.PointOfService.FiscalAdjustmentType param_param_adjustmentType, System.Collections.Generic.IEnumerable<Microsoft.PointOfService.VatInfo> param_param_vatAdjustments)
        {
        }
        public virtual void PrintRecRefund(System.String param_param_description, System.Decimal param_param_amount, System.Int32 param_param_vatInfo)
        {
        }
        public virtual void PrintRecRefundVoid(System.String param_param_description, System.Decimal param_param_amount, System.Int32 param_param_vatInfo)
        {
        }
        public virtual void PrintRecSubtotal(System.Decimal param_param_amount)
        {
        }
        public virtual void PrintRecSubtotalAdjustment(Microsoft.PointOfService.FiscalAdjustment param_param_adjustmentType, System.String param_param_description, System.Decimal param_param_amount)
        {
        }
        public virtual void PrintRecSubtotalAdjustVoid(Microsoft.PointOfService.FiscalAdjustment param_param_adjustmentType, System.Decimal param_param_amount)
        {
        }
        public virtual void PrintRecTaxId(System.String param_param_taxId)
        {
        }
        public virtual void PrintRecTotal(System.Decimal param_param_total, System.Decimal param_param_payment, System.String param_param_description)
        {
        }
        public virtual void PrintRecVoid(System.String param_param_description)
        {
        }
        public virtual void PrintReport(Microsoft.PointOfService.ReportType param_param_reportType, System.String param_param_startNum, System.String param_param_endNum)
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
        public virtual void SetCurrency(Microsoft.PointOfService.FiscalCurrency param_param_newCurrency)
        {
        }
        public virtual void SetDate(System.DateTime param_param_newDate)
        {
        }
        public virtual void SetHeaderLine(System.Int32 param_param_lineNumber, System.String param_param_text, System.Boolean param_param_doubleWidth)
        {
        }
        public virtual void SetPosId(System.String param_param_posId, System.String param_param_cashierId)
        {
        }
        public virtual void SetStoreFiscalId(System.String param_param_id)
        {
        }
        public virtual void SetTrailerLine(System.Int32 param_param_lineNumber, System.String param_param_text, System.Boolean param_param_doubleWidth)
        {
        }
        public virtual void SetVatTable()
        {
        }
        public virtual void SetVatValue(System.Int32 param_param_vatId, System.String param_param_vatValue)
        {
        }
        public virtual void VerifyItem(System.String param_param_itemName, System.Int32 param_param_vatId)
        {
        }
        public virtual void PrintRecItemRefund(System.String param_param_description, System.Decimal param_param_amount, System.Int32 param_param_quantity, System.Int32 param_param_vatInfo, System.Decimal param_param_unitAmount, System.String param_param_unitName)
        {
        }
        public virtual void PrintRecItemRefundVoid(System.String param_param_description, System.Decimal param_param_amount, System.Int32 param_param_quantity, System.Int32 param_param_vatInfo, System.Decimal param_param_unitAmount, System.String param_param_unitName)
        {
        }
        public virtual void ClearOutput()
        {
        }
        public virtual void BeginFiscalDocument(System.Int32 param_param_documentAmount)
        {
        }
        public virtual void BeginFiscalReceipt(System.Boolean param_param_printHeader)
        {
        }
        public virtual void BeginFixedOutput(Microsoft.PointOfService.FiscalReceiptStation param_param_station, System.Int32 param_param_documentType)
        {
        }
        public virtual void BeginInsertion(System.Int32 param_param_timeout)
        {
        }
        public virtual void BeginItemList(System.Int32 param_param_vatId)
        {
        }
        public virtual void BeginNonFiscal()
        {
        }
    }
}
