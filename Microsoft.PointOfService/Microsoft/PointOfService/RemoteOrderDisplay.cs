namespace Microsoft.PointOfService
{
    public class RemoteOrderDisplay : Microsoft.PointOfService.PosCommon
    {
        protected RemoteOrderDisplay()
        {
        }
        public const System.Int32 ClockAll = 0;
        public const System.Int32 ExtendedErrorBadClock = 201;
        public const System.Int32 ExtendedErrorNoClocks = 202;
        public const System.Int32 ExtendedErrorNoRegion = 203;
        public const System.Int32 ExtendedErrorNoBuffers = 204;
        public const System.Int32 ExtendedErrorNoRoom = 205;
        public const System.Int32 CharacterSetUnicode = 997;
        public const System.Int32 CharacterSetAscii = 998;
        public const System.Int32 CharacterSetAnsi = 999;
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
        public System.Boolean CapMapCharacterSet
        {
            get { return false; }
        }
        public System.Boolean CapSelectCharacterSet
        {
            get { return false; }
        }
        public System.Boolean CapTone
        {
            get { return false; }
        }
        public System.Boolean CapTouch
        {
            get { return false; }
        }
        public System.Boolean CapTransaction
        {
            get { return false; }
        }
        public System.Boolean AsyncMode
        {
            get { return false; }
            set { }
        }
        public System.Int32 AutoToneDuration
        {
            get { return 0; }
            set { }
        }
        public System.Int32 AutoToneFrequency
        {
            get { return 0; }
            set { }
        }
        public System.Int32 CharacterSet
        {
            get { return 0; }
        }
        public System.Int32[] CharacterSetList
        {
            get { return null; }
        }
        public System.Int32 Clocks
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.DeviceUnits CurrentUnitId
        {
            get { return Microsoft.PointOfService.DeviceUnits.Unit1; }
            set { }
        }
        public System.String ErrorString
        {
            get { return null; }
        }
        public Microsoft.PointOfService.DeviceUnits ErrorUnits
        {
            get { return Microsoft.PointOfService.DeviceUnits.Unit1; }
        }
        public System.String EventString
        {
            get { return null; }
        }
        public Microsoft.PointOfService.RemoteOrderDisplayEventTypes EventType
        {
            get { return Microsoft.PointOfService.RemoteOrderDisplayEventTypes.TouchUp; }
            set { }
        }
        public Microsoft.PointOfService.DeviceUnits EventUnitId
        {
            get { return Microsoft.PointOfService.DeviceUnits.Unit1; }
        }
        public Microsoft.PointOfService.DeviceUnits EventUnits
        {
            get { return Microsoft.PointOfService.DeviceUnits.Unit1; }
        }
        public System.Boolean MapCharacterSet
        {
            get { return false; }
            set { }
        }
        public System.Int32 SystemClocks
        {
            get { return 0; }
        }
        public System.Int32 SystemVideoSaveBuffers
        {
            get { return 0; }
        }
        public System.Int32 Timeout
        {
            get { return 0; }
            set { }
        }
        public Microsoft.PointOfService.DeviceUnits UnitsOnline
        {
            get { return Microsoft.PointOfService.DeviceUnits.Unit1; }
        }
        public System.Int32 VideoDataCount
        {
            get { return 0; }
        }
        public System.Int32 VideoMode
        {
            get { return 0; }
            set { }
        }
        public Microsoft.PointOfService.VideoMode[] VideoModesList
        {
            get { return null; }
        }
        public System.Int32 VideoSaveBuffers
        {
            get { return 0; }
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
        public virtual void ClearVideo(Microsoft.PointOfService.DeviceUnits param_param_units, Microsoft.PointOfService.VideoAttributes param_param_attribute)
        {
        }
        public virtual void ClearVideoRegion(System.Int32 param_param_row, System.Int32 param_param_column, System.Int32 param_param_height, System.Int32 param_param_width, Microsoft.PointOfService.VideoAttributes param_param_attribute)
        {
        }
        public virtual void ControlClock(Microsoft.PointOfService.DeviceUnits param_param_units, Microsoft.PointOfService.ClockFunction param_param_clockFunction, System.Int32 param_param_clockId, System.Int32 param_param_hours, System.Int32 param_param_minutes, System.Int32 param_param_seconds, System.Int32 param_param_row, System.Int32 param_param_column, Microsoft.PointOfService.VideoAttributes param_param_attribute, Microsoft.PointOfService.ClockMode param_param_mode)
        {
        }
        public virtual void ControlCursor(Microsoft.PointOfService.DeviceUnits param_param_units, Microsoft.PointOfService.VideoCursorType param_param_cursorType)
        {
        }
        public virtual void CopyVideoRegion(Microsoft.PointOfService.DeviceUnits param_param_units, System.Int32 param_param_row, System.Int32 param_param_column, System.Int32 param_param_height, System.Int32 param_param_width, System.Int32 param_param_targetRow, System.Int32 param_param_targetColumn)
        {
        }
        public virtual void DisplayData(Microsoft.PointOfService.DeviceUnits param_param_units, System.Int32 param_param_row, System.Int32 param_param_column, Microsoft.PointOfService.VideoAttributes param_param_attribute, System.String param_param_data)
        {
        }
        public virtual void DrawBox(Microsoft.PointOfService.DeviceUnits param_param_units, System.Int32 param_param_row, System.Int32 param_param_column, System.Int32 param_param_height, System.Int32 param_param_width, Microsoft.PointOfService.VideoAttributes param_param_attribute, Microsoft.PointOfService.BorderType param_param_borderType)
        {
        }
        public virtual void FreeVideoRegion(Microsoft.PointOfService.DeviceUnits param_param_units, System.Int32 param_param_bufferId)
        {
        }
        public virtual void ResetVideo(Microsoft.PointOfService.DeviceUnits param_param_units)
        {
        }
        public virtual void RestoreVideoRegion(Microsoft.PointOfService.DeviceUnits param_param_units, System.Int32 param_param_targetRow, System.Int32 param_param_targetColumn, System.Int32 param_param_bufferId)
        {
        }
        public virtual void SaveVideoRegion(Microsoft.PointOfService.DeviceUnits param_param_units, System.Int32 param_param_row, System.Int32 param_param_column, System.Int32 param_param_height, System.Int32 param_param_width, System.Int32 param_param_bufferId)
        {
        }
        public virtual void SelectCharacterSet(Microsoft.PointOfService.DeviceUnits param_param_units, System.Int32 param_param_characterSet)
        {
        }
        public virtual void SetCursor(Microsoft.PointOfService.DeviceUnits param_param_units, System.Int32 param_param_row, System.Int32 param_param_column)
        {
        }
        public virtual void TransactionDisplay(Microsoft.PointOfService.DeviceUnits param_param_units, Microsoft.PointOfService.RemoteOrderDisplayTransaction param_param_transactionFunction)
        {
        }
        public virtual void UpdateVideoRegionAttribute(Microsoft.PointOfService.DeviceUnits param_param_units, Microsoft.PointOfService.VideoAttributeCommand param_param_attributeFunction, System.Int32 param_param_column, System.Int32 param_param_height, System.Int32 param_param_width, Microsoft.PointOfService.VideoAttributes param_param_attribute)
        {
        }
        public virtual void VideoSound(Microsoft.PointOfService.DeviceUnits param_param_units, System.Int32 param_param_frequency, System.Int32 param_param_duration, System.Int32 param_param_numberOfCycles, System.Int32 param_param_interSoundWait)
        {
        }
    }
}
