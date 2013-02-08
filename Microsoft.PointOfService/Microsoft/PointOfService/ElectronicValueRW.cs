namespace Microsoft.PointOfService
{
    public class ElectronicValueRW : Microsoft.PointOfService.PosCommon
    {
        protected ElectronicValueRW()
        {
        }
        public const System.Int32 StatusLogOk = 11;
        public const System.Int32 StatusLogNearFull = 12;
        public const System.Int32 StatusLogFull = 13;
        public const System.Int32 StatusNoCard = 21;
        public const System.Int32 StatusCardDetected = 22;
        public const System.Int32 StatusCardEntered = 23;
        public const System.Int32 StatusCardCaptured = 24;
        public const System.Int32 ExtendedErrorNoCard = 201;
        public const System.Int32 ExtendedErrorRelease = 202;
        public const System.Int32 ExtendedErrorCenterError = 203;
        public const System.Int32 ExtendedErrorCommandError = 204;
        public const System.Int32 ExtendedErrorReset = 205;
        public const System.Int32 ExtendedErrorCommunicationError = 206;
        public const System.Int32 ExtendedErrorLogOverflow = 207;
        public const System.Int32 ExtendedErrorDailyLogOverflow = 208;
        public const System.Int32 ExtendedErrorDeficient = 209;
        public const System.Int32 ExtendedErrorOverdeposit = 210;
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
        }
        public System.Int32 OutputId
        {
            get { return 0; }
        }
        public System.Boolean AutoDisable
        {
            get { return false; }
            set { }
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
        public System.Decimal Amount
        {
            get { return new System.Decimal(); }
            set { }
        }
        public System.String ApprovalCode
        {
            get { return null; }
            set { }
        }
        public System.Boolean AsyncMode
        {
            get { return false; }
            set { }
        }
        public System.Decimal Balance
        {
            get { return new System.Decimal(); }
        }
        public System.Decimal BalanceOfPoint
        {
            get { return new System.Decimal(); }
        }
        public System.Boolean CapActivateService
        {
            get { return false; }
        }
        public System.Boolean CapAddValue
        {
            get { return false; }
        }
        public System.Boolean CapCancelValue
        {
            get { return false; }
        }
        public Microsoft.PointOfService.CardDetectionTypes CapCardSensor
        {
            get { return Microsoft.PointOfService.CardDetectionTypes.Entry; }
        }
        public Microsoft.PointOfService.CardDetectionControl CapDetectionControl
        {
            get { return Microsoft.PointOfService.CardDetectionControl.Device; }
        }
        public System.Boolean CapElectronicMoney
        {
            get { return false; }
        }
        public System.Boolean CapEnumerateCardServices
        {
            get { return false; }
        }
        public System.Boolean CapIndirectTransactionLog
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
        public System.Boolean CapMediumId
        {
            get { return false; }
        }
        public System.Boolean CapPoint
        {
            get { return false; }
        }
        public System.Boolean CapSubtractValue
        {
            get { return false; }
        }
        public System.Boolean CapTransaction
        {
            get { return false; }
        }
        public System.Boolean CapTransactionLog
        {
            get { return false; }
        }
        public System.Boolean CapUnlockTerminal
        {
            get { return false; }
        }
        public System.Boolean CapUpdateKey
        {
            get { return false; }
        }
        public System.Boolean CapVoucher
        {
            get { return false; }
        }
        public System.Boolean CapWriteValue
        {
            get { return false; }
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.String> CardServiceList
        {
            get { return null; }
        }
        public System.String CurrentService
        {
            get { return null; }
            set { }
        }
        public System.Boolean DetectionControl
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.DetectionState DetectionStatus
        {
            get { return Microsoft.PointOfService.DetectionState.NoCard; }
        }
        public System.DateTime ExpirationDate
        {
            get { return new System.DateTime(); }
        }
        public System.DateTime LastUsedDate
        {
            get { return new System.DateTime(); }
        }
        public Microsoft.PointOfService.LogState LogStatus
        {
            get { return Microsoft.PointOfService.LogState.Ok; }
        }
        public System.String MediumId
        {
            get { return null; }
            set { }
        }
        public System.Decimal Point
        {
            get { return new System.Decimal(); }
            set { }
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.String> ReaderWriterServiceList
        {
            get { return null; }
        }
        public System.Int32 SequenceNumber
        {
            get { return 0; }
        }
        public System.Decimal SettledAmount
        {
            get { return new System.Decimal(); }
        }
        public System.Decimal SettledPoint
        {
            get { return new System.Decimal(); }
        }
        public System.String TransactionLog
        {
            get { return null; }
        }
        public System.String VoucherId
        {
            get { return null; }
            set { }
        }
        public System.String VoucherIdList
        {
            get { return null; }
            set { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DataEventHandler DataEvent
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
        #pragma warning disable 67
        public event Microsoft.PointOfService.OutputCompleteEventHandler OutputCompleteEvent
        {
            add { }
            remove { }
        }
        public virtual void ClearInput()
        {
        }
        public virtual void ClearOutput()
        {
        }
        public virtual void ClearInputProperties()
        {
        }
        public virtual void AccessLog(System.Int32 sequenceNumber, Microsoft.PointOfService.TransactionLogType type, System.Int32 timeout)
        {
        }
        public virtual Microsoft.PointOfService.EVRWResult ActivateService(System.Int32 data, System.Object obj)
        {
            return new Microsoft.PointOfService.EVRWResult();
        }
        public virtual void AddValue(System.Int32 sequenceNumber, System.Int32 timeout)
        {
        }
        public virtual void BeginDetection(Microsoft.PointOfService.BeginDetectionType type, System.Int32 timeout)
        {
        }
        public virtual void BeginRemoval(System.Int32 timeout)
        {
        }
        public virtual void CancelValue(System.Int32 sequenceNumber, System.Int32 timeout)
        {
        }
        public virtual void CaptureCard()
        {
        }
        public virtual void EndDetection()
        {
        }
        public virtual void EndRemoval()
        {
        }
        public virtual void EnumerateCardServices()
        {
        }
        public virtual void LockTerminal()
        {
        }
        public virtual void ReadValue(System.Int32 sequenceNumber, System.Int32 timeout)
        {
        }
        public virtual void SubtractValue(System.Int32 sequenceNumber, System.Int32 timeout)
        {
        }
        public virtual void TransactionAccess(Microsoft.PointOfService.TransactionControl control)
        {
        }
        public virtual void UnlockTerminal()
        {
        }
        public virtual Microsoft.PointOfService.EVRWResult UpdateKey(System.Int32 data, System.Object obj)
        {
            return new Microsoft.PointOfService.EVRWResult();
        }
        public virtual void WriteValue(System.Int32 sequenceNumber, System.Int32 timeout)
        {
        }
    }
}
