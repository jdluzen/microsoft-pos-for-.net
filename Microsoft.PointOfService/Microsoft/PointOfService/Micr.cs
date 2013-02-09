namespace Microsoft.PointOfService
{
    public abstract class Micr : Microsoft.PointOfService.PosCommon
    {
        protected Micr()
        {
        }
        public const System.String StatisticGoodReadCount = "GoodReadCount";
        public const System.String StatisticFailedReadCount = "FailedReadCount";
        public const System.String StatisticFailedDataParseCount = "FailedDataParseCount";
        public const System.Int32 ExtendedErrorNoCheck = 201;
        public const System.Int32 ExtendedErrorCheck = 202;
        public const System.Int32 ExtendedErrorBadData = 203;
        public const System.Int32 ExtendedErrorNoData = 204;
        public const System.Int32 ExtendedErrorBadSize = 205;
        public const System.Int32 ExtendedErrorJam = 206;
        public const System.Int32 ExtendedErrorCheckDigit = 207;
        public const System.Int32 ExtendedErrorCoverOpen = 208;
        public abstract System.Int32 DataCount { get; }
        public abstract System.Boolean DataEventEnabled { get; set;  }
        public abstract System.Boolean AutoDisable { get; set;  }
        public abstract System.String AccountNumber { get; }
        public abstract System.String Amount { get; }
        public abstract System.String BankNumber { get; }
        public abstract System.Boolean CapValidationDevice { get; }
        public abstract Microsoft.PointOfService.CheckType CheckType { get; }
        public abstract Microsoft.PointOfService.CheckCountryCode CountryCode { get; }
        public abstract System.String Epc { get; }
        public abstract System.String RawData { get; }
        public abstract System.String SerialNumber { get; }
        public abstract System.String TransitNumber { get; }
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DataEventHandler DataEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent;
        public virtual void ClearInput()
        {
        }
        
        public virtual void ClearInputProperties()
        {
        }
        
        public virtual void BeginInsertion(System.Int32 timeout)
        {
        }
        
        public virtual void BeginRemoval(System.Int32 timeout)
        {
        }
        
        public virtual void EndInsertion()
        {
        }
        
        public virtual void EndRemoval()
        {
        }
        
    }
}
