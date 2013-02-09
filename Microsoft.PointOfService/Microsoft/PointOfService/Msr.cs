namespace Microsoft.PointOfService
{
    public abstract class Msr : Microsoft.PointOfService.PosCommon
    {
        public abstract class BankCardProperties
        {
            protected BankCardProperties()
            {
            }
            public const System.String AccountNumber = "AccountNumber";
            public const System.String ExpirationDate = "ExpirationDate";
            public const System.String FirstName = "FirstName";
            public const System.String MiddleInitial = "MiddleInitial";
            public const System.String ServiceCode = "ServiceCode";
            public const System.String Suffix = "Suffix";
            public const System.String Surname = "Surname";
            public const System.String Title = "Title";
        }
        public abstract class AamvaCardProperties
        {
            protected AamvaCardProperties()
            {
            }
            public const System.String Address = "Address";
            public const System.String BirthDate = "BirthDate";
            public const System.String City = "City";
            public const System.String Class = "Class";
            public const System.String Endorsements = "Endorsements";
            public const System.String ExpirationDate = "ExpirationDate";
            public const System.String EyeColor = "EyeColor";
            public const System.String FirstName = "FirstName";
            public const System.String Gender = "Gender";
            public const System.String HairColor = "HairColor";
            public const System.String Height = "Height";
            public const System.String LicenseNumber = "LicenseNumber";
            public const System.String PostalCode = "PostalCode";
            public const System.String Restrictions = "Restrictions";
            public const System.String State = "State";
            public const System.String Suffix = "Suffix";
            public const System.String Surname = "Surname";
            public const System.String Weight = "Weight";
        }
        protected Msr()
        {
        }
        public const System.Int32 ExtendedErrorSuccess = 0;
        public const System.Int32 ExtendedErrorFailure = 111;
        public const System.Int32 ExtendedErrorStart = 201;
        public const System.Int32 ExtendedErrorEnd = 202;
        public const System.Int32 ExtendedErrorParity = 203;
        public const System.Int32 ExtendedErrorLrc = 204;
        public const System.Int32 ExtendedErrorDeviceAuthenticationFailed = 205;
        public const System.Int32 ExtendedErrorDeviceDeauthenticationFailed = 206;
        public const System.String StatisticGoodReadCount = "GoodReadCount";
        public const System.String StatisticFailedReadCount = "FailedReadCount";
        public const System.String StatisticUnreadableCardCount = "UnreadableCardCount";
        public const System.String StatisticGoodWriteCount = "GoodWriteCount";
        public const System.String StatisticFailedWriteCount = "FailedWriteCount";
        public const System.String StatisticMissingStartSentinelTrack1Count = "MissingStartSentinelTrack1Count";
        public const System.String StatisticParityLrcErrorTrack1Count = "ParityLRCErrorTrack1Count";
        public const System.String StatisticMissingStartSentinelTrack2Count = "MissingStartSentinelTrack2Count";
        public const System.String StatisticParityLrcErrorTrack2Count = "ParityLRCErrorTrack2Count";
        public const System.String StatisticMissingStartSentinelTrack3Count = "MissingStartSentinelTrack3Count";
        public const System.String StatisticParityLrcErrorTrack3Count = "ParityLRCErrorTrack3Count";
        public const System.String StatisticMissingStartSentinelTrack4Count = "MissingStartSentinelTrack4Count";
        public const System.String StatisticParityLrcErrorTrack4Count = "ParityLRCErrorTrack4Count";
        public const System.String StatisticGoodCardAuthenticationDataCount = "GoodCardAuthenticationDataCount";
        public const System.String StatisticFailedCardAuthenticationDataCount = "FailedCardAuthenticationDataCount";
        public const System.String StatisticChallengeRequestCount = "ChallengeRequestCount";
        public const System.String StatisticGoodDeviceAuthenticationCount = "GoodDeviceAuthenticationCount";
        public const System.String StatisticFailedDeviceAuthenticationCount = "FailedDeviceAuthenticationCount";
        public const System.Int32 StatusDeviceAuthenticated = 11;
        public const System.Int32 StatusDeviceDeauthenticated = 12;
        public const System.String CardTypeBank = "BANK";
        public const System.String CardTypeAamva = "AAMVA";
        public abstract System.Int32 DataCount { get; }
        public abstract System.Boolean DataEventEnabled { get; set;  }
        public abstract System.Boolean AutoDisable { get; set;  }
        public virtual Microsoft.PointOfService.EncryptionAlgorithm CapDataEncryption { get { return Microsoft.PointOfService.EncryptionAlgorithm.None; } }
        public virtual Microsoft.PointOfService.EncryptionAlgorithm DataEncryptionAlgorithm { get { return Microsoft.PointOfService.EncryptionAlgorithm.None; } set { } }
        public virtual System.Byte[] AdditionalSecurityInformation { get { return null; } }
        public virtual System.Byte[] Track1EncryptedData { get { return null; } }
        public virtual System.Int32 Track1EncryptedDataLength { get { return 0; } }
        public virtual System.Byte[] Track2EncryptedData { get { return null; } }
        public virtual System.Int32 Track2EncryptedDataLength { get { return 0; } }
        public virtual System.Byte[] Track3EncryptedData { get { return null; } }
        public virtual System.Int32 Track3EncryptedDataLength { get { return 0; } }
        public virtual System.Byte[] Track4EncryptedData { get { return null; } }
        public virtual System.Int32 Track4EncryptedDataLength { get { return 0; } }
        public virtual System.Boolean CapTrackDataMasking { get { return false; } }
        public virtual System.String CapCardAuthentication { get { return null; } }
        public virtual System.Byte[] CardAuthenticationData { get { return null; } }
        public virtual System.Int32 CardAuthenticationDataLength { get { return 0; } }
        public virtual Microsoft.PointOfService.DeviceAuthenticationLevel CapDeviceAuthentication { get { return Microsoft.PointOfService.DeviceAuthenticationLevel.NotSupported; } }
        public virtual Microsoft.PointOfService.DeviceAuthenticationProtocol DeviceAuthenticationProtocol { get { return Microsoft.PointOfService.DeviceAuthenticationProtocol.None; } }
        public virtual System.Boolean DeviceAuthenticated { get { return false; } }
        public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.String> CardPropertyList { get { return null; } }
        public virtual System.String CardType { get { return null; } }
        public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.String> CardTypeList { get { return null; } }
        public virtual System.String WriteCardType { get { return null; } set { } }
        public abstract System.Boolean CapIso { get; }
        public abstract System.Boolean CapJisOne { get; }
        public abstract System.Boolean CapJisTwo { get; }
        public abstract System.Boolean CapTransmitSentinels { get; }
        public abstract System.String AccountNumber { get; }
        public abstract System.Boolean DecodeData { get; set;  }
        public abstract Microsoft.PointOfService.MsrErrorReporting ErrorReportingType { get; set;  }
        public abstract System.String ExpirationDate { get; }
        public abstract System.String FirstName { get; }
        public abstract System.String MiddleInitial { get; }
        public abstract System.Boolean ParseDecodeData { get; set;  }
        public abstract System.String ServiceCode { get; }
        public abstract System.String Suffix { get; }
        public abstract System.String Surname { get; }
        public abstract System.String Title { get; }
        public abstract System.Byte[] Track1Data { get; }
        public abstract System.Byte[] Track1DiscretionaryData { get; }
        public abstract System.Byte[] Track2Data { get; }
        public abstract System.Byte[] Track2DiscretionaryData { get; }
        public abstract System.Byte[] Track3Data { get; }
        public abstract System.Byte[] Track4Data { get; }
        public abstract Microsoft.PointOfService.MsrTracks TracksToRead { get; set;  }
        public abstract System.Boolean TransmitSentinels { get; set;  }
        public virtual System.Int32 EncodingMaxLength { get { return 0; } }
        public virtual Microsoft.PointOfService.MsrTracks CapWritableTracks { get { return Microsoft.PointOfService.MsrTracks.None; } }
        public virtual Microsoft.PointOfService.MsrTracks TracksToWrite { get { return Microsoft.PointOfService.MsrTracks.None; } set { } }
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
        
        public virtual void UpdateKey(System.String key, System.String keyName)
        {
        }
        
        public virtual void AuthenticateDevice(System.Byte[] responseToken)
        {
        }
        
        public virtual void DeauthenticateDevice(System.Byte[] responseToken)
        {
        }
        
        public virtual System.Byte[] RetrieveDeviceAuthenticationData()
        {
            return null;
        }
        
        public virtual System.String RetrieveCardProperty(System.String name)
        {
            return null;
        }
        
        public virtual void WriteTracks(System.Byte[] track1Data, System.Byte[] track2Data, System.Byte[] track3Data, System.Byte[] track4Data, System.Int32 timeout)
        {
        }
        
    }
}
