namespace Microsoft.PointOfService.BaseServiceObjects
{
    public abstract class PinPadBase : Microsoft.PointOfService.BasicServiceObjects.PinPadBasic, System.IDisposable
    {
        protected PinPadBase()
        {
        }
        public override System.String AccountNumber { get { return null; } set { } }
        public override System.String AdditionalSecurityInformation { get { return null; } }
        public override System.Decimal Amount { get { return new System.Decimal(); } set { } }
        public override System.Globalization.CultureInfo[] AvailableLanguagesList { get { return null; } }
        public override Microsoft.PointOfService.PinPadMessage[] AvailablePromptsList { get { return null; } }
        public override Microsoft.PointOfService.PinPadDisplay CapDisplay { get { return Microsoft.PointOfService.PinPadDisplay.Unrestricted; } }
        public override System.Boolean CapKeyboard { get { return false; } }
        public override Microsoft.PointOfService.PinPadLanguage CapLanguage { get { return Microsoft.PointOfService.PinPadLanguage.None; } }
        public override System.Boolean CapMacCalculation { get { return false; } }
        public override System.Boolean CapTone { get { return false; } }
        public override System.String EncryptedPin { get { return null; } }
        public override System.Int32 MaximumPinLength { get { return 0; } set { } }
        public override System.String MerchantId { get { return null; } set { } }
        public override System.Int32 MinimumPinLength { get { return 0; } set { } }
        public override System.Boolean PinEntryEnabled { get { return false; } }
        public override Microsoft.PointOfService.PinPadMessage Prompt { get { return Microsoft.PointOfService.PinPadMessage.EnterPin; } set { } }
        public override System.Globalization.CultureInfo PromptLanguage { get { return null; } set { } }
        public override System.String TerminalId { get { return null; } set { } }
        public override System.Byte[] Track1Data { get { return null; } set { } }
        public override System.Byte[] Track2Data { get { return null; } set { } }
        public override System.Byte[] Track3Data { get { return null; } set { } }
        public override System.Byte[] Track4Data { get { return null; } set { } }
        public override Microsoft.PointOfService.EftTransactionType TransactionType { get { return Microsoft.PointOfService.EftTransactionType.Debit; } set { } }
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
