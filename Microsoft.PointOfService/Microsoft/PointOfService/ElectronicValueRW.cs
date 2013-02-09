namespace Microsoft.PointOfService
{
    public abstract class ElectronicValueRW : Microsoft.PointOfService.PosCommon
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
        public abstract System.Int32 DataCount { get; }
        public abstract System.Boolean DataEventEnabled { get; set;  }
        public abstract System.Int32 OutputId { get; }
        public abstract System.Boolean AutoDisable { get; set;  }
        public abstract System.String AccountNumber { get; }
        public abstract System.String AdditionalSecurityInformation { get; set;  }
        public abstract System.Decimal Amount { get; set;  }
        public abstract System.String ApprovalCode { get; set;  }
        public abstract System.Boolean AsyncMode { get; set;  }
        public abstract System.Decimal Balance { get; }
        public abstract System.Decimal BalanceOfPoint { get; }
        public abstract System.Boolean CapActivateService { get; }
        public abstract System.Boolean CapAddValue { get; }
        public abstract System.Boolean CapCancelValue { get; }
        public abstract Microsoft.PointOfService.CardDetectionTypes CapCardSensor { get; }
        public abstract Microsoft.PointOfService.CardDetectionControl CapDetectionControl { get; }
        public abstract System.Boolean CapElectronicMoney { get; }
        public abstract System.Boolean CapEnumerateCardServices { get; }
        public abstract System.Boolean CapIndirectTransactionLog { get; }
        public abstract System.Boolean CapLockTerminal { get; }
        public abstract System.Boolean CapLogStatus { get; }
        public abstract System.Boolean CapMediumId { get; }
        public abstract System.Boolean CapPoint { get; }
        public abstract System.Boolean CapSubtractValue { get; }
        public abstract System.Boolean CapTransaction { get; }
        public abstract System.Boolean CapTransactionLog { get; }
        public abstract System.Boolean CapUnlockTerminal { get; }
        public abstract System.Boolean CapUpdateKey { get; }
        public abstract System.Boolean CapVoucher { get; }
        public abstract System.Boolean CapWriteValue { get; }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.String> CardServiceList { get; }
        public abstract System.String CurrentService { get; set;  }
        public abstract System.Boolean DetectionControl { get; set;  }
        public abstract Microsoft.PointOfService.DetectionState DetectionStatus { get; }
        public abstract System.DateTime ExpirationDate { get; }
        public abstract System.DateTime LastUsedDate { get; }
        public abstract Microsoft.PointOfService.LogState LogStatus { get; }
        public abstract System.String MediumId { get; set;  }
        public abstract System.Decimal Point { get; set;  }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.String> ReaderWriterServiceList { get; }
        public abstract System.Int32 SequenceNumber { get; }
        public abstract System.Decimal SettledAmount { get; }
        public abstract System.Decimal SettledPoint { get; }
        public abstract System.String TransactionLog { get; }
        public abstract System.String VoucherId { get; set;  }
        public abstract System.String VoucherIdList { get; set;  }
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DataEventHandler DataEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.OutputCompleteEventHandler OutputCompleteEvent;
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
