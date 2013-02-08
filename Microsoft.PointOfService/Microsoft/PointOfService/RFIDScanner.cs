namespace Microsoft.PointOfService
{
    public abstract class RFIDScanner : Microsoft.PointOfService.PosCommon
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
        public abstract System.Int32 DataCount
        {
            get;
        }
        public abstract System.Boolean DataEventEnabled
        {
            get;
            set;
        }
        public abstract System.Boolean AutoDisable
        {
            get;
            set;
        }
        public abstract System.Int32 OutputId
        {
            get;
        }
        public abstract Microsoft.PointOfService.RFIDProtocols CapMultipleProtocols
        {
            get;
        }
        public abstract System.Boolean CapDisableTag
        {
            get;
        }
        public abstract Microsoft.PointOfService.RFIDProtocols ProtocolMask
        {
            get;
            set;
        }
        public abstract System.Byte[] CurrentTagId
        {
            get;
        }
        public abstract System.Byte[] CurrentTagUserData
        {
            get;
        }
        public abstract Microsoft.PointOfService.RFIDProtocols CurrentTagProtocol
        {
            get;
        }
        public abstract System.Int32 TagCount
        {
            get;
        }
        public abstract System.Boolean CapContinuousRead
        {
            get;
        }
        public abstract System.Boolean ContinuousReadMode
        {
            get;
        }
        public abstract System.Boolean CapReadTimer
        {
            get;
        }
        public abstract System.Int32 ReadTimerInterval
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.WriteTagSections CapWriteTag
        {
            get;
        }
        public abstract System.Boolean CapLockTag
        {
            get;
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
