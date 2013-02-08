namespace Microsoft.PointOfService
{
    public abstract class RemoteOrderDisplay : Microsoft.PointOfService.PosCommon
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
        public abstract System.Boolean CapMapCharacterSet
        {
            get;
        }
        public abstract System.Boolean CapSelectCharacterSet
        {
            get;
        }
        public abstract System.Boolean CapTone
        {
            get;
        }
        public abstract System.Boolean CapTouch
        {
            get;
        }
        public abstract System.Boolean CapTransaction
        {
            get;
        }
        public abstract System.Boolean AsyncMode
        {
            get;
            set;
        }
        public abstract System.Int32 AutoToneDuration
        {
            get;
            set;
        }
        public abstract System.Int32 AutoToneFrequency
        {
            get;
            set;
        }
        public abstract System.Int32 CharacterSet
        {
            get;
        }
        public abstract System.Int32[] CharacterSetList
        {
            get;
        }
        public abstract System.Int32 Clocks
        {
            get;
        }
        public abstract Microsoft.PointOfService.DeviceUnits CurrentUnitId
        {
            get;
            set;
        }
        public abstract System.String ErrorString
        {
            get;
        }
        public abstract Microsoft.PointOfService.DeviceUnits ErrorUnits
        {
            get;
        }
        public abstract System.String EventString
        {
            get;
        }
        public abstract Microsoft.PointOfService.RemoteOrderDisplayEventTypes EventType
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.DeviceUnits EventUnitId
        {
            get;
        }
        public abstract Microsoft.PointOfService.DeviceUnits EventUnits
        {
            get;
        }
        public abstract System.Boolean MapCharacterSet
        {
            get;
            set;
        }
        public abstract System.Int32 SystemClocks
        {
            get;
        }
        public abstract System.Int32 SystemVideoSaveBuffers
        {
            get;
        }
        public abstract System.Int32 Timeout
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.DeviceUnits UnitsOnline
        {
            get;
        }
        public abstract System.Int32 VideoDataCount
        {
            get;
        }
        public abstract System.Int32 VideoMode
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.VideoMode[] VideoModesList
        {
            get;
        }
        public abstract System.Int32 VideoSaveBuffers
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
        public virtual void ClearVideo(Microsoft.PointOfService.DeviceUnits units, Microsoft.PointOfService.VideoAttributes attribute)
        {
        }
        public virtual void ClearVideoRegion(System.Int32 row, System.Int32 column, System.Int32 height, System.Int32 width, Microsoft.PointOfService.VideoAttributes attribute)
        {
        }
        public virtual void ControlClock(Microsoft.PointOfService.DeviceUnits units, Microsoft.PointOfService.ClockFunction clockFunction, System.Int32 clockId, System.Int32 hours, System.Int32 minutes, System.Int32 seconds, System.Int32 row, System.Int32 column, Microsoft.PointOfService.VideoAttributes attribute, Microsoft.PointOfService.ClockMode mode)
        {
        }
        public virtual void ControlCursor(Microsoft.PointOfService.DeviceUnits units, Microsoft.PointOfService.VideoCursorType cursorType)
        {
        }
        public virtual void CopyVideoRegion(Microsoft.PointOfService.DeviceUnits units, System.Int32 row, System.Int32 column, System.Int32 height, System.Int32 width, System.Int32 targetRow, System.Int32 targetColumn)
        {
        }
        public virtual void DisplayData(Microsoft.PointOfService.DeviceUnits units, System.Int32 row, System.Int32 column, Microsoft.PointOfService.VideoAttributes attribute, System.String data)
        {
        }
        public virtual void DrawBox(Microsoft.PointOfService.DeviceUnits units, System.Int32 row, System.Int32 column, System.Int32 height, System.Int32 width, Microsoft.PointOfService.VideoAttributes attribute, Microsoft.PointOfService.BorderType borderType)
        {
        }
        public virtual void FreeVideoRegion(Microsoft.PointOfService.DeviceUnits units, System.Int32 bufferId)
        {
        }
        public virtual void ResetVideo(Microsoft.PointOfService.DeviceUnits units)
        {
        }
        public virtual void RestoreVideoRegion(Microsoft.PointOfService.DeviceUnits units, System.Int32 targetRow, System.Int32 targetColumn, System.Int32 bufferId)
        {
        }
        public virtual void SaveVideoRegion(Microsoft.PointOfService.DeviceUnits units, System.Int32 row, System.Int32 column, System.Int32 height, System.Int32 width, System.Int32 bufferId)
        {
        }
        public virtual void SelectCharacterSet(Microsoft.PointOfService.DeviceUnits units, System.Int32 characterSet)
        {
        }
        public virtual void SetCursor(Microsoft.PointOfService.DeviceUnits units, System.Int32 row, System.Int32 column)
        {
        }
        public virtual void TransactionDisplay(Microsoft.PointOfService.DeviceUnits units, Microsoft.PointOfService.RemoteOrderDisplayTransaction transactionFunction)
        {
        }
        public virtual void UpdateVideoRegionAttribute(Microsoft.PointOfService.DeviceUnits units, Microsoft.PointOfService.VideoAttributeCommand attributeFunction, System.Int32 column, System.Int32 height, System.Int32 width, Microsoft.PointOfService.VideoAttributes attribute)
        {
        }
        public virtual void VideoSound(Microsoft.PointOfService.DeviceUnits units, System.Int32 frequency, System.Int32 duration, System.Int32 numberOfCycles, System.Int32 interSoundWait)
        {
        }
    }
}
