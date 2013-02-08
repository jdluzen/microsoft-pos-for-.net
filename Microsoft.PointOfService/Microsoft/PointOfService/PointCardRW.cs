namespace Microsoft.PointOfService
{
    public class PointCardRW : Microsoft.PointOfService.PosCommon
    {
        protected PointCardRW()
        {
        }
        public const System.Int32 StatusNoCard = 1;
        public const System.Int32 StatusRemaining = 2;
        public const System.Int32 StatusInserted = 4;
        public const System.Int32 CharacterSetUnicode = 997;
        public const System.Int32 CharacterSetAscii = 998;
        public const System.Int32 CharacterSetAnsi = 999;
        public const System.Int32 ExtendedErrorRead = 201;
        public const System.Int32 ExtendedErrorWrite = 202;
        public const System.Int32 ExtendedErrorJam = 203;
        public const System.Int32 ExtendedErrorMotor = 204;
        public const System.Int32 ExtendedErrorCover = 205;
        public const System.Int32 ExtendedErrorPrinter = 206;
        public const System.Int32 ExtendedErrorRelease = 207;
        public const System.Int32 ExtendedErrorDisplay = 208;
        public const System.Int32 ExtendedErrorNoCard = 209;
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
        public System.Boolean CapBold
        {
            get { return false; }
        }
        public System.Boolean CapCardEntranceSensor
        {
            get { return false; }
        }
        public Microsoft.PointOfService.CharacterSetCapability CapCharacterSet
        {
            get { return Microsoft.PointOfService.CharacterSetCapability.Numeric; }
        }
        public System.Boolean CapCleanCard
        {
            get { return false; }
        }
        public System.Boolean CapClearPrint
        {
            get { return false; }
        }
        public System.Boolean CapDHigh
        {
            get { return false; }
        }
        public System.Boolean CapDWide
        {
            get { return false; }
        }
        public System.Boolean CapDWideDHigh
        {
            get { return false; }
        }
        public System.Boolean CapItalic
        {
            get { return false; }
        }
        public System.Boolean CapLeft90
        {
            get { return false; }
        }
        public System.Boolean CapMapCharacterSet
        {
            get { return false; }
        }
        public System.Boolean CapPrint
        {
            get { return false; }
        }
        public System.Boolean CapPrintMode
        {
            get { return false; }
        }
        public System.Boolean CapRight90
        {
            get { return false; }
        }
        public System.Boolean CapRotate180
        {
            get { return false; }
        }
        public Microsoft.PointOfService.PointCardRWTracks CapTracksToRead
        {
            get { return Microsoft.PointOfService.PointCardRWTracks.Track1; }
        }
        public Microsoft.PointOfService.PointCardRWTracks CapTracksToWrite
        {
            get { return Microsoft.PointOfService.PointCardRWTracks.Track1; }
        }
        public Microsoft.PointOfService.PointCardState CardState
        {
            get { return Microsoft.PointOfService.PointCardState.NoCard; }
        }
        public System.Int32 CharacterSet
        {
            get { return 0; }
            set { }
        }
        public System.Int32[] CharacterSetList
        {
            get { return null; }
        }
        public System.String[] FontTypefaceList
        {
            get { return null; }
        }
        public System.Int32 LineChars
        {
            get { return 0; }
            set { }
        }
        public System.Int32[] LineCharsList
        {
            get { return null; }
        }
        public System.Int32 LineHeight
        {
            get { return 0; }
            set { }
        }
        public System.Int32 LineSpacing
        {
            get { return 0; }
            set { }
        }
        public System.Int32 LineWidth
        {
            get { return 0; }
        }
        public System.Boolean MapCharacterSet
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.MapMode MapMode
        {
            get { return Microsoft.PointOfService.MapMode.Dots; }
            set { }
        }
        public System.Int32 MaxLine
        {
            get { return 0; }
        }
        public System.Int32 PrintHeight
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.PointCardReadWriteStates ReadState
        {
            get { return new Microsoft.PointOfService.PointCardReadWriteStates(); }
        }
        public Microsoft.PointOfService.PointCardReceiveLengths RecvLength
        {
            get { return new Microsoft.PointOfService.PointCardReceiveLengths(); }
        }
        public System.Int32 SidewaysMaxChars
        {
            get { return 0; }
        }
        public System.Int32 SidewaysMaxLines
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.PointCardRWTracks TracksToRead
        {
            get { return Microsoft.PointOfService.PointCardRWTracks.Track1; }
            set { }
        }
        public Microsoft.PointOfService.PointCardRWTracks TracksToWrite
        {
            get { return Microsoft.PointOfService.PointCardRWTracks.Track1; }
            set { }
        }
        public System.Byte[] Track1Data
        {
            get { return null; }
        }
        public System.Byte[] Track2Data
        {
            get { return null; }
        }
        public System.Byte[] Track3Data
        {
            get { return null; }
        }
        public System.Byte[] Track4Data
        {
            get { return null; }
        }
        public System.Byte[] Track5Data
        {
            get { return null; }
        }
        public System.Byte[] Track6Data
        {
            get { return null; }
        }
        public Microsoft.PointOfService.PointCardReadWriteStates WriteState
        {
            get { return new Microsoft.PointOfService.PointCardReadWriteStates(); }
        }
        public System.Byte[] Write1Data
        {
            get { return null; }
            set { }
        }
        public System.Byte[] Write2Data
        {
            get { return null; }
            set { }
        }
        public System.Byte[] Write3Data
        {
            get { return null; }
            set { }
        }
        public System.Byte[] Write4Data
        {
            get { return null; }
            set { }
        }
        public System.Byte[] Write5Data
        {
            get { return null; }
            set { }
        }
        public System.Byte[] Write6Data
        {
            get { return null; }
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
        public virtual void ClearInputProperties()
        {
        }
        public virtual void ClearOutput()
        {
        }
        public virtual void BeginInsertion(System.Int32 param_param_timeout)
        {
        }
        public virtual void BeginRemoval(System.Int32 param_param_timeout)
        {
        }
        public virtual void CleanCard()
        {
        }
        public virtual void ClearPrintWrite(Microsoft.PointOfService.PointCardAreas param_param_kind, System.Int32 param_param_horizontalPosition, System.Int32 param_param_verticalPosition, System.Int32 param_param_width, System.Int32 param_param_height)
        {
        }
        public virtual void PrintWrite(Microsoft.PointOfService.PointCardAreas param_param_kind, System.Int32 param_param_horizontalPosition, System.Int32 param_param_verticalPosition, System.String param_param_data)
        {
        }
        public virtual void RotatePrint(Microsoft.PointOfService.Rotation param_param_rotation)
        {
        }
        public virtual void ValidateData(System.String param_param_data)
        {
        }
        public virtual void EndInsertion()
        {
        }
        public virtual void EndRemoval()
        {
        }
    }
}
