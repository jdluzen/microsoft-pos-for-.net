namespace Microsoft.PointOfService
{
    public abstract class CashChanger : Microsoft.PointOfService.PosCommon
    {
        protected CashChanger()
        {
        }
        public const System.Int32 StatusOK = 0;
        public const System.Int32 StatusEmpty = 11;
        public const System.Int32 StatusNearEmpty = 12;
        public const System.Int32 StatusEmptyOK = 13;
        public const System.Int32 StatusFull = 21;
        public const System.Int32 StatusNearFull = 22;
        public const System.Int32 StatusFullOK = 23;
        public const System.Int32 StatusJam = 31;
        public const System.Int32 StatusJamOK = 32;
        public const System.Int32 StatusAsync = 91;
        public const System.Int32 ExtendedErrorOverDispense = 201;
        public abstract System.Int32 DataCount { get; }
        public abstract System.Boolean DataEventEnabled { get; set;  }
        public abstract System.Boolean CapDeposit { get; }
        public abstract System.Boolean CapDepositDataEvent { get; }
        public abstract System.Boolean CapDiscrepancy { get; }
        public abstract System.Boolean CapEmptySensor { get; }
        public abstract System.Boolean CapFullSensor { get; }
        public virtual System.Boolean CapJamSensor { get { return false; } }
        public abstract System.Boolean CapNearEmptySensor { get; }
        public abstract System.Boolean CapNearFullSensor { get; }
        public abstract System.Boolean CapPauseDeposit { get; }
        public virtual System.Boolean CapRealTimeData { get { return false; } }
        public abstract System.Boolean CapRepayDeposit { get; }
        public abstract System.Boolean AsyncMode { get; set;  }
        public abstract System.Int32 AsyncResultCode { get; }
        public abstract System.Int32 AsyncResultCodeExtended { get; }
        public abstract Microsoft.PointOfService.CashUnits CurrencyCashList { get; }
        public abstract System.String CurrencyCode { get; set;  }
        public abstract System.String[] CurrencyCodeList { get; }
        public abstract System.Int32 CurrentExit { get; set;  }
        public virtual System.Int32 CurrentService { get { return 0; } set { } }
        public abstract System.Int32 DepositAmount { get; }
        public abstract Microsoft.PointOfService.CashUnits DepositCashList { get; }
        public abstract System.String[] DepositCodeList { get; }
        public abstract Microsoft.PointOfService.CashCount[] DepositCounts { get; }
        public abstract Microsoft.PointOfService.CashDepositStatus DepositStatus { get; }
        public abstract System.Int32 DeviceExits { get; }
        public abstract Microsoft.PointOfService.CashChangerStatus DeviceStatus { get; }
        public abstract Microsoft.PointOfService.CashUnits ExitCashList { get; }
        public abstract Microsoft.PointOfService.CashChangerFullStatus FullStatus { get; }
        public virtual System.Boolean RealTimeDataEnabled { get { return false; } set { } }
        public virtual System.Int32 ServiceCount { get { return 0; } }
        public virtual Microsoft.PointOfService.ServiceIndex ServiceIndex { get { return new Microsoft.PointOfService.ServiceIndex(); } }
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DataEventHandler DataEvent;
        public virtual void ClearInput()
        {
        }
        
        public virtual void AdjustCashCounts(System.Collections.Generic.IEnumerable<Microsoft.PointOfService.CashCount> cashCounts)
        {
        }
        
        public virtual void BeginDeposit()
        {
        }
        
        public virtual void DispenseCash(Microsoft.PointOfService.CashCount[] cashCounts)
        {
        }
        
        public virtual void DispenseChange(System.Int32 amount)
        {
        }
        
        public virtual void EndDeposit(Microsoft.PointOfService.CashDepositAction successAction)
        {
        }
        
        public virtual void FixDeposit()
        {
        }
        
        public virtual void PauseDeposit(Microsoft.PointOfService.CashDepositPause pauseAction)
        {
        }
        
        public virtual Microsoft.PointOfService.CashCounts ReadCashCounts()
        {
            return new Microsoft.PointOfService.CashCounts();
        }
        
    }
}
