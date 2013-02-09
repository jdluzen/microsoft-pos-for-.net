namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class MsrProperties : Microsoft.PointOfService.BasicServiceObjects.CommonProperties
    {
        protected MsrProperties()
        {
        }
        public System.Boolean CapIso { get { return false; } set { } }
        public System.Boolean CapJisOne { get { return false; } set { } }
        public System.Boolean CapJisTwo { get { return false; } set { } }
        public System.Boolean CapTransmitSentinels { get { return false; } set { } }
        public Microsoft.PointOfService.EncryptionAlgorithm CapDataEncryption { get { return Microsoft.PointOfService.EncryptionAlgorithm.None; } set { } }
        public Microsoft.PointOfService.EncryptionAlgorithm DataEncryptionAlgorithm { get { return Microsoft.PointOfService.EncryptionAlgorithm.None; } set { } }
        public System.String CapCardAuthentication { get { return null; } set { } }
        public Microsoft.PointOfService.DeviceAuthenticationLevel CapDeviceAuthentication { get { return Microsoft.PointOfService.DeviceAuthenticationLevel.NotSupported; } set { } }
        public System.Boolean CapTrackDataMasking { get { return false; } set { } }
        public System.Collections.Generic.List<System.String> CardTypeList { get { return null; } set { } }
        public System.Boolean DeviceAuthenticated { get { return false; } set { } }
        public Microsoft.PointOfService.DeviceAuthenticationProtocol DeviceAuthenticationProtocol { get { return Microsoft.PointOfService.DeviceAuthenticationProtocol.None; } set { } }
        public System.String WriteCardType { get { return null; } set { } }
    }
}
