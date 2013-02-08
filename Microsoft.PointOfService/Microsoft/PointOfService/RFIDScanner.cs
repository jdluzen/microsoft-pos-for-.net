namespace Microsoft.PointOfService
{
    public class RFIDScanner : Microsoft.PointOfService.PosCommon
    {
        protected RFIDScanner()
        {
        }
        public const System.Int32 StatusLowMemory = 100;
        public const System.Int32 StatusExcessNoise = 101;
        public const System.Int32 ExtendedErrorAntennaFailure = 300;
        public const System.String StatisticTagReadCount = "TagReadCount";
        public const System.String StatisticGoodTagWriteCount = "GoodTagWriteCount";
        public const System.String StatisticFailedTagWriteCount = "FailedTagWriteCount";
        public const System.String StatisticGoodTagLockCount = "GoodTagLockCount";
        public const System.String StatisticFailedTagLockCount = "FailedTagLockCount";
        public const System.String StatisticGoodTagDisableCount = "GoodTagDisableCount";
        public const System.String StatisticFailedTagDisableCount = "FailedTagDisableCount";
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
        }
        public System.Boolean AutoDisable
        {
            get { return false; }
            set { }
        }
        public System.Int32 OutputId
        {
            get { return 0; }
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
        #pragma warning disable 67
        public event Microsoft.PointOfService.DataEventHandler DataEvent
        {
            add { }
            remove { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.OutputCompleteEventHandler OutputCompleteEvent
        {
            add { }
            remove { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent
        {
            add { }
            remove { }
        }
        public virtual void ClearInput()
        {
        }
        public virtual void ClearOutput()
        {
        }
        public virtual void ClearInputProperties()
        {
        }
        public virtual void DisableTag(System.Byte[] tagId, System.Int32 timeout, System.Byte[] password)
        {
        }
        public virtual void ReadTags(Microsoft.PointOfService.RFIDReadOptions cmd, System.Byte[] filterId, System.Byte[] filterMask, System.Int32 start, System.Int32 length, System.Int32 timeout, System.Byte[] password)
        {
        }
        public virtual void WriteTagData(System.Byte[] tagId, System.Byte[] userData, System.Int32 start, System.Int32 timeout, System.Byte[] password)
        {
        }
        public virtual void WriteTagId(System.Byte[] sourceTagId, System.Byte[] destinationTagId, System.Int32 timeout, System.Byte[] password)
        {
        }
        public virtual void LockTag(System.Byte[] tagId, System.Int32 timeout, System.Byte[] password)
        {
        }
        public virtual void FirstTag()
        {
        }
        public virtual void NextTag()
        {
        }
        public virtual void PreviousTag()
        {
        }
        public virtual void StartReadTags(Microsoft.PointOfService.RFIDReadOptions cmd, System.Byte[] filterId, System.Byte[] filterMask, System.Int32 start, System.Int32 length, System.Byte[] password)
        {
        }
        public virtual void StopReadTags(System.Byte[] password)
        {
        }
    }
}
