namespace Microsoft.PointOfService
{
    public abstract class ElectronicJournal : Microsoft.PointOfService.PosCommon
    {
        protected ElectronicJournal()
        {
        }
        public const System.Int32 StatusMediumNearFull = 1;
        public const System.Int32 StatusMediumFull = 2;
        public const System.Int32 StatusMediumRemoved = 3;
        public const System.Int32 StatusMediumInserted = 4;
        public const System.Int32 StatusMediumSuspended = 5;
        public const System.Int32 StatusIdle = 6;
        public const System.Int32 ExtendedErrorExisting = 201;
        public const System.Int32 ExtendedErrorMediumFull = 202;
        public const System.Int32 ExtendedErrorMultipleMarker = 203;
        public const System.Int32 ExtendedErrorUninitializedMedium = 204;
        public const System.Int32 ExtendedErrorCorruptedMedium = 205;
        public const System.Int32 ExtendedErrorUnknownDataFormat = 206;
        public const System.Int32 ExtendedErrorNotEnoughSpace = 207;
        public const System.Int32 ExtendedErrorMultipleMarkers = 208;
        public const System.String StatisticWriteCount = "WriteCount";
        public const System.String StatisticFailedWriteCount = "FailedWriteCount";
        public const System.String StatisticEraseCount = "EraseCount";
        public const System.String StatisticMediumRemovedCount = "MediumRemovedCount";
        public const System.String StatisticMediumSize = "MediumSize";
        public const System.String StatisticMediumFreeSpace = "MediumFreeSpace";
        public abstract System.Int32 DataCount
        {
            get;
        }
        public abstract System.Boolean DataEventEnabled
        {
            get;
            set;
        }
        public abstract System.Int32 OutputId
        {
            get;
        }
        public abstract System.Boolean AutoDisable
        {
            get;
            set;
        }
        public abstract System.Boolean AsyncMode
        {
            get;
            set;
        }
        public abstract System.Boolean CapAddMarker
        {
            get;
        }
        public abstract System.Boolean CapErasableMedium
        {
            get;
        }
        public abstract System.Boolean CapInitializeMedium
        {
            get;
        }
        public abstract System.Boolean CapMediumIsAvailable
        {
            get;
        }
        public abstract System.Boolean CapPrintContent
        {
            get;
        }
        public abstract System.Boolean CapPrintContentFile
        {
            get;
        }
        public abstract System.Boolean CapRetrieveCurrentMarker
        {
            get;
        }
        public abstract System.Boolean CapRetrieveMarker
        {
            get;
        }
        public abstract System.Boolean CapRetrieveMarkerByDateTime
        {
            get;
        }
        public abstract System.Boolean CapRetrieveMarkersDateTime
        {
            get;
        }
        public abstract Microsoft.PointOfService.ElectronicJournalStations CapStation
        {
            get;
        }
        public abstract System.Boolean CapStorageEnabled
        {
            get;
        }
        public abstract System.Boolean CapSuspendPrintContent
        {
            get;
        }
        public abstract System.Boolean CapSuspendQueryContent
        {
            get;
        }
        public abstract System.Boolean CapWatermark
        {
            get;
        }
        public abstract System.Boolean FlagWhenIdle
        {
            get;
            set;
        }
        public abstract System.Decimal MediumFreeSpace
        {
            get;
        }
        public abstract System.String MediumId
        {
            get;
        }
        public abstract System.Boolean MediumIsAvailable
        {
            get;
        }
        public abstract System.Decimal MediumSize
        {
            get;
        }
        public abstract Microsoft.PointOfService.ElectronicJournalStations Station
        {
            get;
            set;
        }
        public abstract System.Boolean StorageEnabled
        {
            get;
            set;
        }
        public abstract System.Boolean Suspended
        {
            get;
        }
        public abstract System.Boolean Watermark
        {
            get;
            set;
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DataEventHandler DataEvent
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
        #pragma warning disable 67
        public event Microsoft.PointOfService.OutputCompleteEventHandler OutputCompleteEvent
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
        public virtual void AddMarker(System.String marker)
        {
        }
        public virtual void CancelPrintContent()
        {
        }
        public virtual void CancelQueryContent()
        {
        }
        public virtual void EraseMedium()
        {
        }
        public virtual void InitializeMedium(System.String mediumId)
        {
        }
        public virtual void PrintContent(System.String fromMarker, System.String toMarker)
        {
        }
        public virtual void PrintContentFile(System.String fileName)
        {
        }
        public virtual void QueryContent(System.String fileName, System.String fromMarker, System.String toMarker)
        {
        }
        public virtual void ResumePrintContent()
        {
        }
        public virtual void ResumeQueryContent()
        {
        }
        public virtual System.String RetrieveCurrentMarker(Microsoft.PointOfService.MarkerType markerType)
        {
            return null;
        }
        public virtual System.String RetrieveMarker(Microsoft.PointOfService.MarkerType markerType, System.Int32 sessionNumber, System.Int32 documentNumber)
        {
            return null;
        }
        public virtual System.String RetrieveMarkerByDateTime(Microsoft.PointOfService.MarkerType markerType, System.String dateTime, System.String markerNumber)
        {
            return null;
        }
        public virtual System.String RetrieveMarkersDateTime(System.String marker)
        {
            return null;
        }
        public virtual void SuspendPrintContent()
        {
        }
        public virtual void SuspendQueryContent()
        {
        }
    }
}
