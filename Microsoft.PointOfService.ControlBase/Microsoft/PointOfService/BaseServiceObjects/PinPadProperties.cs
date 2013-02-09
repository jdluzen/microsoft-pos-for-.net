namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class PinPadProperties : Microsoft.PointOfService.BasicServiceObjects.CommonProperties
    {
        protected PinPadProperties()
        {
        }
        public System.String AccountNumber { get { return null; } set { } }
        public System.String AdditionalSecurityInformation { get { return null; } set { } }
        public System.Decimal Amount { get { return new System.Decimal(); } set { } }
        public System.Globalization.CultureInfo[] AvailableLanguagesList { get { return null; } set { } }
        public Microsoft.PointOfService.PinPadMessage[] AvailablePromptsList { get { return null; } set { } }
        public Microsoft.PointOfService.PinPadDisplay CapDisplay { get { return Microsoft.PointOfService.PinPadDisplay.Unrestricted; } set { } }
        public System.Boolean CapKeyboard { get { return false; } set { } }
        public Microsoft.PointOfService.PinPadLanguage CapLanguage { get { return Microsoft.PointOfService.PinPadLanguage.None; } set { } }
        public System.Boolean CapMacCalculation { get { return false; } set { } }
        public System.Boolean CapTone { get { return false; } set { } }
        public System.String EncryptedPin { get { return null; } set { } }
        public System.Int32 MaximumPinLength { get { return 0; } set { } }
        public System.String MerchantId { get { return null; } set { } }
        public System.Int32 MinimumPinLength { get { return 0; } set { } }
        public System.Boolean PinEntryEnabled { get { return false; } set { } }
        public Microsoft.PointOfService.PinPadMessage Prompt { get { return Microsoft.PointOfService.PinPadMessage.EnterPin; } set { } }
        public System.Globalization.CultureInfo PromptLanguage { get { return null; } set { } }
        public System.String TerminalId { get { return null; } set { } }
        public System.Byte[] Track1Data { get { return null; } set { } }
        public System.Byte[] Track2Data { get { return null; } set { } }
        public System.Byte[] Track3Data { get { return null; } set { } }
        public System.Byte[] Track4Data { get { return null; } set { } }
        public Microsoft.PointOfService.EftTransactionType TransactionType { get { return Microsoft.PointOfService.EftTransactionType.Debit; } set { } }
    }
}
