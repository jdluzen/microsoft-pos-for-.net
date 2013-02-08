namespace Microsoft.PointOfService
{
    public class Micr : Microsoft.PointOfService.PosCommon
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
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
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
        public System.String Amount
        {
            get { return null; }
        }
        public System.String BankNumber
        {
            get { return null; }
        }
        public System.Boolean CapValidationDevice
        {
            get { return false; }
        }
        public Microsoft.PointOfService.CheckType CheckType
        {
            get { return Microsoft.PointOfService.CheckType.Personal; }
        }
        public Microsoft.PointOfService.CheckCountryCode CountryCode
        {
            get { return Microsoft.PointOfService.CheckCountryCode.Usa; }
        }
        public System.String Epc
        {
            get { return null; }
        }
        public System.String RawData
        {
            get { return null; }
        }
        public System.String SerialNumber
        {
            get { return null; }
        }
        public System.String TransitNumber
        {
            get { return null; }
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
        public virtual void ClearInput()
        {
        }
        public virtual void ClearInputProperties()
        {
        }
        public virtual void BeginInsertion(System.Int32 param_param_timeout)
        {
        }
        public virtual void BeginRemoval(System.Int32 param_param_timeout)
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
