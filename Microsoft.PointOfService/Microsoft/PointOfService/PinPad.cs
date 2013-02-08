namespace Microsoft.PointOfService
{
    public class PinPad : Microsoft.PointOfService.PosCommon
    {
        protected PinPad()
        {
        }
        public const System.Int32 ExtendedErrorBadKey = 201;
        public const System.String StatisticValidPINEntryCount = "ValidPINEntryCount";
        public const System.String StatisticInvalidPINEntryCount = "InvalidPINEntryCount";
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.PinPadDisplay CapDisplay
        {
            get { return Microsoft.PointOfService.PinPadDisplay.Unrestricted; }
        }
        public System.Boolean CapKeyboard
        {
            get { return false; }
        }
        public Microsoft.PointOfService.PinPadLanguage CapLanguage
        {
            get { return Microsoft.PointOfService.PinPadLanguage.None; }
        }
        public System.Boolean CapMacCalculation
        {
            get { return false; }
        }
        public System.Boolean CapTone
        {
            get { return false; }
        }
        public System.String AccountNumber
        {
            get { return null; }
            set { }
        }
        public System.String AdditionalSecurityInformation
        {
            get { return null; }
        }
        public System.Decimal Amount
        {
            get { return new System.Decimal(); }
            set { }
        }
        public System.Globalization.CultureInfo[] AvailableLanguagesList
        {
            get { return null; }
        }
        public Microsoft.PointOfService.PinPadMessage[] AvailablePromptsList
        {
            get { return null; }
        }
        public System.String EncryptedPin
        {
            get { return null; }
        }
        public System.Int32 MaximumPinLength
        {
            get { return 0; }
            set { }
        }
        public System.String MerchantId
        {
            get { return null; }
            set { }
        }
        public System.Int32 MinimumPinLength
        {
            get { return 0; }
            set { }
        }
        public System.Boolean PinEntryEnabled
        {
            get { return false; }
        }
        public Microsoft.PointOfService.PinPadMessage Prompt
        {
            get { return Microsoft.PointOfService.PinPadMessage.EnterPin; }
            set { }
        }
        public System.Globalization.CultureInfo PromptLanguage
        {
            get { return null; }
            set { }
        }
        public System.String TerminalId
        {
            get { return null; }
            set { }
        }
        public System.Byte[] Track1Data
        {
            get { return null; }
            set { }
        }
        public System.Byte[] Track2Data
        {
            get { return null; }
            set { }
        }
        public System.Byte[] Track3Data
        {
            get { return null; }
            set { }
        }
        public System.Byte[] Track4Data
        {
            get { return null; }
            set { }
        }
        public Microsoft.PointOfService.EftTransactionType TransactionType
        {
            get { return Microsoft.PointOfService.EftTransactionType.Debit; }
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
        public virtual void ClearInput()
        {
        }
        public virtual void ClearInputProperties()
        {
        }
        public virtual void BeginEftTransaction(Microsoft.PointOfService.PinPadSystem param_param_pinpadSystem, System.Int32 param_param_transactionHost)
        {
        }
        public virtual System.String ComputeMac(System.String param_param_inMsg)
        {
            return null;
        }
        public virtual void EnablePinEntry()
        {
        }
        public virtual void EndEftTransaction(Microsoft.PointOfService.EftTransactionCompletion param_param_completionCode)
        {
        }
        public virtual void UpdateKey(System.Int32 param_param_keyNumber, System.String param_param_key)
        {
        }
        public virtual void VerifyMac(System.String param_param_message)
        {
        }
    }
}
