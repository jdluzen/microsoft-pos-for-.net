namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class PinPadBase : Microsoft.PointOfService.BasicServiceObjects.PinPadBasic, System.IDisposable
    {
        protected PinPadBase()
        {
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
        public override void Open()
        {
        }
        public override void ClearInputProperties()
        {
        }
        public override void BeginEftTransaction(Microsoft.PointOfService.PinPadSystem pinpadSystem, System.Int32 transactionHost)
        {
        }
        public override System.String ComputeMac(System.String inMsg)
        {
            return null;
        }
        public override void EnablePinEntry()
        {
        }
        public override void EndEftTransaction(Microsoft.PointOfService.EftTransactionCompletion completionCode)
        {
        }
        public override void UpdateKey(System.Int32 keyNumber, System.String key)
        {
        }
        public override void VerifyMac(System.String message)
        {
        }
    }
}
