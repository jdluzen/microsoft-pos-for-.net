namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class MsrBase : Microsoft.PointOfService.BasicServiceObjects.MsrBasic, System.IDisposable
    {
        protected MsrBase()
        {
        }
        public System.Byte[] AdditionalSecurityInformation
        {
            get { return null; }
        }
        public System.Byte[] CardAuthenticationData
        {
            get { return null; }
        }
        public System.Int32 CardAuthenticationDataLength
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.EncryptionAlgorithm CapDataEncryption
        {
            get { return Microsoft.PointOfService.EncryptionAlgorithm.None; }
        }
        public Microsoft.PointOfService.EncryptionAlgorithm DataEncryptionAlgorithm
        {
            get { return Microsoft.PointOfService.EncryptionAlgorithm.None; }
            set { }
        }
        public System.String AccountNumber
        {
            get { return null; }
        }
        public System.String MiddleInitial
        {
            get { return null; }
        }
        public System.String FirstName
        {
            get { return null; }
        }
        public System.String ServiceCode
        {
            get { return null; }
        }
        public System.String Surname
        {
            get { return null; }
        }
        public System.String Suffix
        {
            get { return null; }
        }
        public System.String ExpirationDate
        {
            get { return null; }
        }
        public System.String Title
        {
            get { return null; }
        }
        public System.Byte[] Track1DiscretionaryData
        {
            get { return null; }
        }
        public System.Byte[] Track2DiscretionaryData
        {
            get { return null; }
        }
        public System.Byte[] Track1Data
        {
            get { return null; }
        }
        public System.Byte[] Track2Data
        {
            get { return null; }
        }
        public System.Byte[] Track3Data
        {
            get { return null; }
        }
        public System.Byte[] Track4Data
        {
            get { return null; }
        }
        public System.Byte[] Track1EncryptedData
        {
            get { return null; }
        }
        public System.Byte[] Track2EncryptedData
        {
            get { return null; }
        }
        public System.Byte[] Track3EncryptedData
        {
            get { return null; }
        }
        public System.Byte[] Track4EncryptedData
        {
            get { return null; }
        }
        public System.Int32 Track1EncryptedDataLength
        {
            get { return 0; }
        }
        public System.Int32 Track2EncryptedDataLength
        {
            get { return 0; }
        }
        public System.Int32 Track3EncryptedDataLength
        {
            get { return 0; }
        }
        public System.Int32 Track4EncryptedDataLength
        {
            get { return 0; }
        }
        public System.Boolean CapIso
        {
            get { return false; }
        }
        public System.Boolean CapJisOne
        {
            get { return false; }
        }
        public System.Boolean CapJisTwo
        {
            get { return false; }
        }
        public System.Boolean CapTransmitSentinels
        {
            get { return false; }
        }
        public Microsoft.PointOfService.MsrErrorReporting ErrorReportingType
        {
            get { return Microsoft.PointOfService.MsrErrorReporting.Card; }
            set { }
        }
        public Microsoft.PointOfService.MsrTracks TracksToRead
        {
            get { return Microsoft.PointOfService.MsrTracks.None; }
            set { }
        }
        public System.Boolean ParseDecodeData
        {
            get { return false; }
            set { }
        }
        public System.Boolean DecodeData
        {
            get { return false; }
            set { }
        }
        public System.Boolean TransmitSentinels
        {
            get { return false; }
            set { }
        }
        public System.String CapCardAuthentication
        {
            get { return null; }
        }
        public Microsoft.PointOfService.DeviceAuthenticationLevel CapDeviceAuthentication
        {
            get { return Microsoft.PointOfService.DeviceAuthenticationLevel.NotSupported; }
        }
        public System.Boolean CapTrackDataMasking
        {
            get { return false; }
        }
        public System.String CardType
        {
            get { return null; }
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.String> CardTypeList
        {
            get { return null; }
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.String> CardPropertyList
        {
            get { return null; }
        }
        public System.Boolean DeviceAuthenticated
        {
            get { return false; }
        }
        public Microsoft.PointOfService.DeviceAuthenticationProtocol DeviceAuthenticationProtocol
        {
            get { return Microsoft.PointOfService.DeviceAuthenticationProtocol.None; }
        }
        public System.String WriteCardType
        {
            get { return null; }
            set { }
        }
        public Microsoft.PointOfService.MsrTracks CapWritableTracks
        {
            get { return Microsoft.PointOfService.MsrTracks.None; }
        }
        public Microsoft.PointOfService.MsrTracks TracksToWrite
        {
            get { return Microsoft.PointOfService.MsrTracks.None; }
            set { }
        }
        public System.Int32 EncodingMaxLength
        {
            get { return 0; }
        }
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
