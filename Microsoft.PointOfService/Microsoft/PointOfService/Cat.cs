namespace Microsoft.PointOfService
{
    public abstract class Cat : Microsoft.PointOfService.PosCommon
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
        public abstract System.Int32 OutputId
        {
            get;
        }
        public abstract System.Boolean CapAdditionalSecurityInformation
        {
            get;
        }
        public abstract System.Boolean CapAuthorizeCompletion
        {
            get;
        }
        public abstract System.Boolean CapAuthorizePreSales
        {
            get;
        }
        public abstract System.Boolean CapAuthorizeRefund
        {
            get;
        }
        public abstract System.Boolean CapAuthorizeVoid
        {
            get;
        }
        public abstract System.Boolean CapAuthorizeVoidPreSales
        {
            get;
        }
        public abstract System.Boolean CapCenterResultCode
        {
            get;
        }
        public abstract System.Boolean CapCheckCard
        {
            get;
        }
        public abstract Microsoft.PointOfService.CatLogs CapDailyLog
        {
            get;
        }
        public abstract System.Boolean CapInstallments
        {
            get;
        }
        public abstract System.Boolean CapPaymentDetail
        {
            get;
        }
        public abstract System.Boolean CapTaxOthers
        {
            get;
        }
        public abstract System.Boolean CapTransactionNumber
        {
            get;
        }
        public abstract System.Boolean CapTrainingMode
        {
            get;
        }
        public abstract System.String AccountNumber
        {
            get;
        }
        public abstract System.String AdditionalSecurityInformation
        {
            get;
            set;
        }
        public abstract System.String ApprovalCode
        {
            get;
        }
        public abstract System.Boolean AsyncMode
        {
            get;
            set;
        }
        public abstract System.String CardCompanyId
        {
            get;
        }
        public abstract System.String CenterResultCode
        {
            get;
        }
        public abstract System.String DailyLog
        {
            get;
        }
        public abstract Microsoft.PointOfService.PaymentCondition PaymentCondition
        {
            get;
        }
        public abstract System.String PaymentDetail
        {
            get;
        }
        public abstract Microsoft.PointOfService.PaymentMedia PaymentMedia
        {
            get;
            set;
        }
        public abstract System.Int32 SequenceNumber
        {
            get;
        }
        public abstract System.String SlipNumber
        {
            get;
        }
        public abstract System.Boolean TrainingMode
        {
            get;
            set;
        }
        public abstract System.String TransactionNumber
        {
            get;
        }
        public abstract Microsoft.PointOfService.CreditTransactionType TransactionType
        {
            get;
        }
        public virtual System.Decimal Balance
        {
            get { return new System.Decimal(); }
        }
        public virtual System.Boolean CapCashDeposit
        {
            get { return false; }
        }
        public virtual System.Boolean CapLockTerminal
        {
            get { return false; }
        }
        public virtual System.Boolean CapLogStatus
        {
            get { return false; }
        }
        public virtual System.Boolean CapUnlockTerminal
        {
            get { return false; }
        }
        public virtual Microsoft.PointOfService.DealingLogStatus LogStatus
        {
            get { return Microsoft.PointOfService.DealingLogStatus.Ok; }
        }
        public virtual System.Decimal SettledAmount
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
