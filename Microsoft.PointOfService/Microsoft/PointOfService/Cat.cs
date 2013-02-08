namespace Microsoft.PointOfService
{
    public class Cat : Microsoft.PointOfService.PosCommon
    {
        protected Cat()
        {
        }
        public const System.Int32 ExtendedErrorCenterError = 1;
        public const System.Int32 ExtendedErrorCommandError = 90;
        public const System.Int32 ExtendedErrorReset = 91;
        public const System.Int32 ExtendedErrorCommunicationError = 92;
        public const System.Int32 ExtendedErrorDailyLogOverflow = 200;
        public const System.Int32 ExtendedErrorDeficient = 201;
        public const System.Int32 ExtendedErrorOverDeposit = 202;
        public System.Int32 OutputId
        {
            get { return 0; }
        }
        public System.Boolean CapAdditionalSecurityInformation
        {
            get { return false; }
        }
        public System.Boolean CapAuthorizeCompletion
        {
            get { return false; }
        }
        public System.Boolean CapAuthorizePreSales
        {
            get { return false; }
        }
        public System.Boolean CapAuthorizeRefund
        {
            get { return false; }
        }
        public System.Boolean CapAuthorizeVoid
        {
            get { return false; }
        }
        public System.Boolean CapAuthorizeVoidPreSales
        {
            get { return false; }
        }
        public System.Boolean CapCenterResultCode
        {
            get { return false; }
        }
        public System.Boolean CapCheckCard
        {
            get { return false; }
        }
        public Microsoft.PointOfService.CatLogs CapDailyLog
        {
            get { return Microsoft.PointOfService.CatLogs.None; }
        }
        public System.Boolean CapInstallments
        {
            get { return false; }
        }
        public System.Boolean CapPaymentDetail
        {
            get { return false; }
        }
        public System.Boolean CapTaxOthers
        {
            get { return false; }
        }
        public System.Boolean CapTransactionNumber
        {
            get { return false; }
        }
        public System.Boolean CapTrainingMode
        {
            get { return false; }
        }
        public System.String AccountNumber
        {
            get { return null; }
        }
        public System.String AdditionalSecurityInformation
        {
            get { return null; }
            set { }
        }
        public System.String ApprovalCode
        {
            get { return null; }
        }
        public System.Boolean AsyncMode
        {
            get { return false; }
            set { }
        }
        public System.String CardCompanyId
        {
            get { return null; }
        }
        public System.String CenterResultCode
        {
            get { return null; }
        }
        public System.String DailyLog
        {
            get { return null; }
        }
        public Microsoft.PointOfService.PaymentCondition PaymentCondition
        {
            get { return Microsoft.PointOfService.PaymentCondition.Lump; }
        }
        public System.String PaymentDetail
        {
            get { return null; }
        }
        public Microsoft.PointOfService.PaymentMedia PaymentMedia
        {
            get { return Microsoft.PointOfService.PaymentMedia.Unspecified; }
            set { }
        }
        public System.Int32 SequenceNumber
        {
            get { return 0; }
        }
        public System.String SlipNumber
        {
            get { return null; }
        }
        public System.Boolean TrainingMode
        {
            get { return false; }
            set { }
        }
        public System.String TransactionNumber
        {
            get { return null; }
        }
        public Microsoft.PointOfService.CreditTransactionType TransactionType
        {
            get { return Microsoft.PointOfService.CreditTransactionType.Sales; }
        }
        public System.Decimal Balance
        {
            get { return new System.Decimal(); }
        }
        public System.Boolean CapCashDeposit
        {
            get { return false; }
        }
        public System.Boolean CapLockTerminal
        {
            get { return false; }
        }
        public System.Boolean CapLogStatus
        {
            get { return false; }
        }
        public System.Boolean CapUnlockTerminal
        {
            get { return false; }
        }
        public Microsoft.PointOfService.DealingLogStatus LogStatus
        {
            get { return Microsoft.PointOfService.DealingLogStatus.Ok; }
        }
        public System.Decimal SettledAmount
        {
            get { return new System.Decimal(); }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent
        {
            add { }
            remove { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.OutputCompleteEventHandler OutputCompleteEvent
        {
            add { }
            remove { }
        }
        public virtual void ClearOutput()
        {
        }
        public virtual void AccessDailyLog(System.Int32 sequenceNumber, Microsoft.PointOfService.CatLogs type, System.Int32 timeout)
        {
        }
        public virtual void AuthorizeCompletion(System.Int32 sequenceNumber, System.Decimal amount, System.Decimal taxOthers, System.Int32 timeout)
        {
        }
        public virtual void AuthorizePreSales(System.Int32 sequenceNumber, System.Decimal amount, System.Decimal taxOthers, System.Int32 timeout)
        {
        }
        public virtual void AuthorizeRefund(System.Int32 sequenceNumber, System.Decimal amount, System.Decimal taxOthers, System.Int32 timeout)
        {
        }
        public virtual void AuthorizeSales(System.Int32 sequenceNumber, System.Decimal amount, System.Decimal taxOthers, System.Int32 timeout)
        {
        }
        public virtual void AuthorizeVoid(System.Int32 sequenceNumber, System.Decimal amount, System.Decimal taxOthers, System.Int32 timeout)
        {
        }
        public virtual void AuthorizeVoidPreSales(System.Int32 sequenceNumber, System.Decimal amount, System.Decimal taxOthers, System.Int32 timeout)
        {
        }
        public virtual void CheckCard(System.Int32 sequenceNumber, System.Int32 timeout)
        {
        }
        public virtual void CashDeposit(System.Int32 sequenceNumber, System.Decimal amount, System.Int32 timeout)
        {
        }
        public virtual void LockTerminal()
        {
        }
        public virtual void UnlockTerminal()
        {
        }
    }
}
