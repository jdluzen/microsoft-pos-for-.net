namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class RFIDScannerBase : Microsoft.PointOfService.BasicServiceObjects.RFIDScannerBasic, System.IDisposable
    {
        protected RFIDScannerBase()
        {
        }
        public Microsoft.PointOfService.RFIDProtocols CapMultipleProtocols
        {
            get { return Microsoft.PointOfService.RFIDProtocols.EpcClass0; }
        }
        public System.Boolean CapDisableTag
        {
            get { return false; }
        }
        public Microsoft.PointOfService.RFIDProtocols ProtocolMask
        {
            get { return Microsoft.PointOfService.RFIDProtocols.EpcClass0; }
            set { }
        }
        public System.Byte[] CurrentTagId
        {
            get { return null; }
        }
        public System.Byte[] CurrentTagUserData
        {
            get { return null; }
        }
        public Microsoft.PointOfService.RFIDProtocols CurrentTagProtocol
        {
            get { return Microsoft.PointOfService.RFIDProtocols.EpcClass0; }
        }
        public System.Int32 TagCount
        {
            get { return 0; }
        }
        public System.Boolean CapContinuousRead
        {
            get { return false; }
        }
        public System.Boolean ContinuousReadMode
        {
            get { return false; }
        }
        public System.Boolean CapReadTimer
        {
            get { return false; }
        }
        public System.Int32 ReadTimerInterval
        {
            get { return 0; }
            set { }
        }
        public Microsoft.PointOfService.WriteTagSections CapWriteTag
        {
            get { return Microsoft.PointOfService.WriteTagSections.None; }
        }
        public System.Boolean CapLockTag
        {
            get { return false; }
        }
        public System.String CheckHealthText
        {
            get { return null; }
        }
        public override void Open()
        {
        }
        public override void ReadTags(Microsoft.PointOfService.RFIDReadOptions param_cmd, System.Byte[] param_filterId, System.Byte[] param_filterMask, System.Int32 param_start, System.Int32 param_length, System.Int32 param_timeout, System.Byte[] param_password)
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
        public override void StartReadTags(Microsoft.PointOfService.RFIDReadOptions param_cmd, System.Byte[] param_filterId, System.Byte[] param_filterMask, System.Int32 param_start, System.Int32 param_length, System.Byte[] param_password)
        {
        }
        public override void StopReadTags(System.Byte[] param_password)
        {
        }
        public override System.String CheckHealth(Microsoft.PointOfService.HealthCheckLevel param_level)
        {
            return null;
        }
        public override void ClearInputProperties()
        {
        }
        public override void WriteTagData(System.Byte[] param_tagId, System.Byte[] param_userData, System.Int32 param_start, System.Int32 param_timeout, System.Byte[] param_password)
        {
        }
        public virtual void WriteTagDataImpl(System.Byte[] param_tagId, System.Byte[] param_userData, System.Int32 param_start, System.Int32 param_timeout, System.Byte[] param_password, System.DateTime param_startTime)
        {
        }
    }
}
