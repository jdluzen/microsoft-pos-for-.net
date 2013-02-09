namespace Microsoft.PointOfService
{
    public abstract class PinPad : Microsoft.PointOfService.PosCommon
    {
        protected PinPad()
        {
        }
        public const System.Int32 ExtendedErrorBadKey = 201;
        public const System.String StatisticValidPINEntryCount = "ValidPINEntryCount";
        public const System.String StatisticInvalidPINEntryCount = "InvalidPINEntryCount";
        public abstract System.Int32 DataCount { get; }
        public abstract System.Boolean DataEventEnabled { get; set;  }
        public abstract Microsoft.PointOfService.PinPadDisplay CapDisplay { get; }
        public abstract System.Boolean CapKeyboard { get; }
        public abstract Microsoft.PointOfService.PinPadLanguage CapLanguage { get; }
        public abstract System.Boolean CapMacCalculation { get; }
        public abstract System.Boolean CapTone { get; }
        public abstract System.String AccountNumber { get; set;  }
        public abstract System.String AdditionalSecurityInformation { get; }
        public abstract System.Decimal Amount { get; set;  }
        public abstract System.Globalization.CultureInfo[] AvailableLanguagesList { get; }
        public abstract Microsoft.PointOfService.PinPadMessage[] AvailablePromptsList { get; }
        public abstract System.String EncryptedPin { get; }
        public abstract System.Int32 MaximumPinLength { get; set;  }
        public abstract System.String MerchantId { get; set;  }
        public abstract System.Int32 MinimumPinLength { get; set;  }
        public abstract System.Boolean PinEntryEnabled { get; }
        public abstract Microsoft.PointOfService.PinPadMessage Prompt { get; set;  }
        public abstract System.Globalization.CultureInfo PromptLanguage { get; set;  }
        public abstract System.String TerminalId { get; set;  }
        public abstract System.Byte[] Track1Data { get; set;  }
        public abstract System.Byte[] Track2Data { get; set;  }
        public abstract System.Byte[] Track3Data { get; set;  }
        public abstract System.Byte[] Track4Data { get; set;  }
        public abstract Microsoft.PointOfService.EftTransactionType TransactionType { get; set;  }
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
        
        public virtual void BeginEftTransaction(Microsoft.PointOfService.PinPadSystem pinpadSystem, System.Int32 transactionHost)
        {
        }
        
        public virtual System.String ComputeMac(System.String inMsg)
        {
            return null;
        }
        
        public virtual void EnablePinEntry()
        {
        }
        
        public virtual void EndEftTransaction(Microsoft.PointOfService.EftTransactionCompletion completionCode)
        {
        }
        
        public virtual void UpdateKey(System.Int32 keyNumber, System.String key)
        {
        }
        
        public virtual void VerifyMac(System.String message)
        {
        }
        
    }
}
