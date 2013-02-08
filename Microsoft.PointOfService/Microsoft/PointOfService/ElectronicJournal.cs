namespace Microsoft.PointOfService
{
    public class ElectronicJournal : Microsoft.PointOfService.PosCommon
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
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
        }
        public System.Int32 OutputId
        {
            get { return 0; }
        }
        public System.Boolean AutoDisable
        {
            get { return false; }
            set { }
        }
        public System.Boolean AsyncMode
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapAddMarker
        {
            get { return false; }
        }
        public System.Boolean CapErasableMedium
        {
            get { return false; }
        }
        public System.Boolean CapInitializeMedium
        {
            get { return false; }
        }
        public System.Boolean CapMediumIsAvailable
        {
            get { return false; }
        }
        public System.Boolean CapPrintContent
        {
            get { return false; }
        }
        public System.Boolean CapPrintContentFile
        {
            get { return false; }
        }
        public System.Boolean CapRetrieveCurrentMarker
        {
            get { return false; }
        }
        public System.Boolean CapRetrieveMarker
        {
            get { return false; }
        }
        public System.Boolean CapRetrieveMarkerByDateTime
        {
            get { return false; }
        }
        public System.Boolean CapRetrieveMarkersDateTime
        {
            get { return false; }
        }
        public Microsoft.PointOfService.ElectronicJournalStations CapStation
        {
            get { return Microsoft.PointOfService.ElectronicJournalStations.Receipt; }
        }
        public System.Boolean CapStorageEnabled
        {
            get { return false; }
        }
        public System.Boolean CapSuspendPrintContent
        {
            get { return false; }
        }
        public System.Boolean CapSuspendQueryContent
        {
            get { return false; }
        }
        public System.Boolean CapWatermark
        {
            get { return false; }
        }
        public System.Boolean FlagWhenIdle
        {
            get { return false; }
            set { }
        }
        public System.Decimal MediumFreeSpace
        {
            get { return new System.Decimal(); }
        }
        public System.String MediumId
        {
            get { return null; }
        }
        public System.Boolean MediumIsAvailable
        {
            get { return false; }
        }
        public System.Decimal MediumSize
        {
            get { return new System.Decimal(); }
        }
        public Microsoft.PointOfService.ElectronicJournalStations Station
        {
            get { return Microsoft.PointOfService.ElectronicJournalStations.Receipt; }
            set { }
        }
        public System.Boolean StorageEnabled
        {
            get { return false; }
            set { }
        }
        public System.Boolean Suspended
        {
            get { return false; }
        }
        public System.Boolean Watermark
        {
            get { return false; }
            set { }
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
        public virtual void AddMarker(System.String param_param_marker)
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
        public virtual void InitializeMedium(System.String param_param_mediumId)
        {
        }
        public virtual void PrintContent(System.String param_param_fromMarker, System.String param_param_toMarker)
        {
        }
        public virtual void PrintContentFile(System.String param_param_fileName)
        {
        }
        public virtual void QueryContent(System.String param_param_fileName, System.String param_param_fromMarker, System.String param_param_toMarker)
        {
        }
        public virtual void ResumePrintContent()
        {
        }
        public virtual void ResumeQueryContent()
        {
        }
        public virtual System.String RetrieveCurrentMarker(Microsoft.PointOfService.MarkerType param_param_markerType)
        {
            return null;
        }
        public virtual System.String RetrieveMarker(Microsoft.PointOfService.MarkerType param_param_markerType, System.Int32 param_param_sessionNumber, System.Int32 param_param_documentNumber)
        {
            return null;
        }
        public virtual System.String RetrieveMarkerByDateTime(Microsoft.PointOfService.MarkerType param_param_markerType, System.String param_param_dateTime, System.String param_param_markerNumber)
        {
            return null;
        }
        public virtual System.String RetrieveMarkersDateTime(System.String param_param_marker)
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
