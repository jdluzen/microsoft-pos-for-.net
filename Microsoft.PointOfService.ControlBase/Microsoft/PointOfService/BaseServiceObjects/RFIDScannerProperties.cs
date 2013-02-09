namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class RFIDScannerProperties : Microsoft.PointOfService.BasicServiceObjects.CommonProperties
    {
        protected RFIDScannerProperties()
        {
        }
        public Microsoft.PointOfService.RFIDProtocols CapMultipleProtocols { get { return Microsoft.PointOfService.RFIDProtocols.EpcClass0; } set { } }
        public System.Boolean CapDisableTag { get { return false; } set { } }
        public Microsoft.PointOfService.RFIDProtocols ProtocolMask { get { return Microsoft.PointOfService.RFIDProtocols.EpcClass0; } set { } }
        public System.Byte[] CurrentTagId { get { return null; } set { } }
        public System.Byte[] CurrentTagUserData { get { return null; } set { } }
        public Microsoft.PointOfService.RFIDProtocols CurrentTagProtocol { get { return Microsoft.PointOfService.RFIDProtocols.EpcClass0; } set { } }
        public System.Boolean CapContinuousRead { get { return false; } set { } }
        public System.Boolean ContinuousReadMode { get { return false; } set { } }
        public System.Boolean CapReadTimer { get { return false; } set { } }
        public System.Int32 ReadTimerInterval { get { return 0; } set { } }
        public Microsoft.PointOfService.WriteTagSections CapWriteTag { get { return Microsoft.PointOfService.WriteTagSections.None; } set { } }
        public System.Boolean CapLockTag { get { return false; } set { } }
    }
}
