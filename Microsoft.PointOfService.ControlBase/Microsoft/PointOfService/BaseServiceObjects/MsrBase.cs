namespace Microsoft.PointOfService.BaseServiceObjects
{
    public abstract class MsrBase : Microsoft.PointOfService.BasicServiceObjects.MsrBasic, System.IDisposable
    {
        protected MsrBase()
        {
        }
        public override System.Byte[] AdditionalSecurityInformation { get { return null; } }
        public override System.Byte[] CardAuthenticationData { get { return null; } }
        public override System.Int32 CardAuthenticationDataLength { get { return 0; } }
        public override Microsoft.PointOfService.EncryptionAlgorithm CapDataEncryption { get { return Microsoft.PointOfService.EncryptionAlgorithm.None; } }
        public override Microsoft.PointOfService.EncryptionAlgorithm DataEncryptionAlgorithm { get { return Microsoft.PointOfService.EncryptionAlgorithm.None; } set { } }
        public override System.String AccountNumber { get { return null; } }
        public override System.String MiddleInitial { get { return null; } }
        public override System.String FirstName { get { return null; } }
        public override System.String ServiceCode { get { return null; } }
        public override System.String Surname { get { return null; } }
        public override System.String Suffix { get { return null; } }
        public override System.String ExpirationDate { get { return null; } }
        public override System.String Title { get { return null; } }
        public override System.Byte[] Track1DiscretionaryData { get { return null; } }
        public override System.Byte[] Track2DiscretionaryData { get { return null; } }
        public override System.Byte[] Track1Data { get { return null; } }
        public override System.Byte[] Track2Data { get { return null; } }
        public override System.Byte[] Track3Data { get { return null; } }
        public override System.Byte[] Track4Data { get { return null; } }
        public override System.Byte[] Track1EncryptedData { get { return null; } }
        public override System.Byte[] Track2EncryptedData { get { return null; } }
        public override System.Byte[] Track3EncryptedData { get { return null; } }
        public override System.Byte[] Track4EncryptedData { get { return null; } }
        public override System.Int32 Track1EncryptedDataLength { get { return 0; } }
        public override System.Int32 Track2EncryptedDataLength { get { return 0; } }
        public override System.Int32 Track3EncryptedDataLength { get { return 0; } }
        public override System.Int32 Track4EncryptedDataLength { get { return 0; } }
        public override System.Boolean CapIso { get { return false; } }
        public override System.Boolean CapJisOne { get { return false; } }
        public override System.Boolean CapJisTwo { get { return false; } }
        public override System.Boolean CapTransmitSentinels { get { return false; } }
        public override Microsoft.PointOfService.MsrErrorReporting ErrorReportingType { get { return Microsoft.PointOfService.MsrErrorReporting.Card; } set { } }
        public override Microsoft.PointOfService.MsrTracks TracksToRead { get { return Microsoft.PointOfService.MsrTracks.None; } set { } }
        public override System.Boolean ParseDecodeData { get { return false; } set { } }
        public override System.Boolean DecodeData { get { return false; } set { } }
        public override System.Boolean TransmitSentinels { get { return false; } set { } }
        public override System.String CapCardAuthentication { get { return null; } }
        public override Microsoft.PointOfService.DeviceAuthenticationLevel CapDeviceAuthentication { get { return Microsoft.PointOfService.DeviceAuthenticationLevel.NotSupported; } }
        public override System.Boolean CapTrackDataMasking { get { return false; } }
        public override System.String CardType { get { return null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.String> CardTypeList { get { return null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.String> CardPropertyList { get { return null; } }
        public override System.Boolean DeviceAuthenticated { get { return false; } }
        public override Microsoft.PointOfService.DeviceAuthenticationProtocol DeviceAuthenticationProtocol { get { return Microsoft.PointOfService.DeviceAuthenticationProtocol.None; } }
        public override System.String WriteCardType { get { return null; } set { } }
        public override Microsoft.PointOfService.MsrTracks CapWritableTracks { get { return Microsoft.PointOfService.MsrTracks.None; } }
        public override Microsoft.PointOfService.MsrTracks TracksToWrite { get { return Microsoft.PointOfService.MsrTracks.None; } set { } }
        public override System.Int32 EncodingMaxLength { get { return 0; } }
        public override void Open()
        {
        }
        
        public override void ClearInputProperties()
        {
        }
        
        public override void WriteTracks(System.Byte[] track1Data, System.Byte[] track2Data, System.Byte[] track3Data, System.Byte[] track4Data, System.Int32 timeout)
        {
        }
        
        public override System.String RetrieveCardProperty(System.String name)
        {
            return null;
        }
        
    }
}
