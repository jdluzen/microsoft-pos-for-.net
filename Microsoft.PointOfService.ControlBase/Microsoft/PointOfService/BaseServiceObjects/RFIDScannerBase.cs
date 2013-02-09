namespace Microsoft.PointOfService.BaseServiceObjects
{
    public abstract class RFIDScannerBase : Microsoft.PointOfService.BasicServiceObjects.RFIDScannerBasic, System.IDisposable
    {
        protected RFIDScannerBase()
        {
        }
        public override Microsoft.PointOfService.RFIDProtocols CapMultipleProtocols { get { return Microsoft.PointOfService.RFIDProtocols.EpcClass0; } }
        public override System.Boolean CapDisableTag { get { return false; } }
        public override Microsoft.PointOfService.RFIDProtocols ProtocolMask { get { return Microsoft.PointOfService.RFIDProtocols.EpcClass0; } set { } }
        public override System.Byte[] CurrentTagId { get { return null; } }
        public override System.Byte[] CurrentTagUserData { get { return null; } }
        public override Microsoft.PointOfService.RFIDProtocols CurrentTagProtocol { get { return Microsoft.PointOfService.RFIDProtocols.EpcClass0; } }
        public override System.Int32 TagCount { get { return 0; } }
        public override System.Boolean CapContinuousRead { get { return false; } }
        public override System.Boolean ContinuousReadMode { get { return false; } }
        public override System.Boolean CapReadTimer { get { return false; } }
        public override System.Int32 ReadTimerInterval { get { return 0; } set { } }
        public override Microsoft.PointOfService.WriteTagSections CapWriteTag { get { return Microsoft.PointOfService.WriteTagSections.None; } }
        public override System.Boolean CapLockTag { get { return false; } }
        public override System.String CheckHealthText { get { return null; } }
        public override void Open()
        {
        }
        
        public override void ReadTags(Microsoft.PointOfService.RFIDReadOptions cmd, System.Byte[] filterId, System.Byte[] filterMask, System.Int32 start, System.Int32 length, System.Int32 timeout, System.Byte[] password)
        {
        }
        
        public override void FirstTag()
        {
        }
        
        public override void NextTag()
        {
        }
        
        public override void PreviousTag()
        {
        }
        
        public override void StartReadTags(Microsoft.PointOfService.RFIDReadOptions cmd, System.Byte[] filterId, System.Byte[] filterMask, System.Int32 start, System.Int32 length, System.Byte[] password)
        {
        }
        
        public override void StopReadTags(System.Byte[] password)
        {
        }
        
        public override System.String CheckHealth(Microsoft.PointOfService.HealthCheckLevel level)
        {
            return null;
        }
        
        public override void ClearInputProperties()
        {
        }
        
        public override void WriteTagData(System.Byte[] tagId, System.Byte[] userData, System.Int32 start, System.Int32 timeout, System.Byte[] password)
        {
        }
        
        public virtual void WriteTagDataImpl(System.Byte[] tagId, System.Byte[] userData, System.Int32 start, System.Int32 timeout, System.Byte[] password, System.DateTime startTime)
        {
        }
        
    }
}
