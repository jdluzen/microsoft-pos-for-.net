namespace Microsoft.PointOfService
{
    public abstract class PointCardRW : Microsoft.PointOfService.PosCommon
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
        public abstract System.Boolean CapBold
        {
            get;
        }
        public abstract System.Boolean CapCardEntranceSensor
        {
            get;
        }
        public abstract Microsoft.PointOfService.CharacterSetCapability CapCharacterSet
        {
            get;
        }
        public abstract System.Boolean CapCleanCard
        {
            get;
        }
        public abstract System.Boolean CapClearPrint
        {
            get;
        }
        public abstract System.Boolean CapDHigh
        {
            get;
        }
        public abstract System.Boolean CapDWide
        {
            get;
        }
        public abstract System.Boolean CapDWideDHigh
        {
            get;
        }
        public abstract System.Boolean CapItalic
        {
            get;
        }
        public abstract System.Boolean CapLeft90
        {
            get;
        }
        public abstract System.Boolean CapMapCharacterSet
        {
            get;
        }
        public abstract System.Boolean CapPrint
        {
            get;
        }
        public abstract System.Boolean CapPrintMode
        {
            get;
        }
        public abstract System.Boolean CapRight90
        {
            get;
        }
        public abstract System.Boolean CapRotate180
        {
            get;
        }
        public abstract Microsoft.PointOfService.PointCardRWTracks CapTracksToRead
        {
            get;
        }
        public abstract Microsoft.PointOfService.PointCardRWTracks CapTracksToWrite
        {
            get;
        }
        public abstract Microsoft.PointOfService.PointCardState CardState
        {
            get;
        }
        public abstract System.Int32 CharacterSet
        {
            get;
            set;
        }
        public abstract System.Int32[] CharacterSetList
        {
            get;
        }
        public abstract System.String[] FontTypefaceList
        {
            get;
        }
        public abstract System.Int32 LineChars
        {
            get;
            set;
        }
        public abstract System.Int32[] LineCharsList
        {
            get;
        }
        public abstract System.Int32 LineHeight
        {
            get;
            set;
        }
        public abstract System.Int32 LineSpacing
        {
            get;
            set;
        }
        public abstract System.Int32 LineWidth
        {
            get;
        }
        public abstract System.Boolean MapCharacterSet
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.MapMode MapMode
        {
            get;
            set;
        }
        public abstract System.Int32 MaxLine
        {
            get;
        }
        public abstract System.Int32 PrintHeight
        {
            get;
        }
        public abstract Microsoft.PointOfService.PointCardReadWriteStates ReadState
        {
            get;
        }
        public abstract Microsoft.PointOfService.PointCardReceiveLengths RecvLength
        {
            get;
        }
        public abstract System.Int32 SidewaysMaxChars
        {
            get;
        }
        public abstract System.Int32 SidewaysMaxLines
        {
            get;
        }
        public abstract Microsoft.PointOfService.PointCardRWTracks TracksToRead
        {
            get;
            set;
        }
        public abstract Microsoft.PointOfService.PointCardRWTracks TracksToWrite
        {
            get;
            set;
        }
        public abstract System.Byte[] Track1Data
        {
            get;
        }
        public abstract System.Byte[] Track2Data
        {
            get;
        }
        public abstract System.Byte[] Track3Data
        {
            get;
        }
        public abstract System.Byte[] Track4Data
        {
            get;
        }
        public abstract System.Byte[] Track5Data
        {
            get;
        }
        public abstract System.Byte[] Track6Data
        {
            get;
        }
        public abstract Microsoft.PointOfService.PointCardReadWriteStates WriteState
        {
            get;
        }
        public abstract System.Byte[] Write1Data
        {
            get;
            set;
        }
        public abstract System.Byte[] Write2Data
        {
            get;
            set;
        }
        public abstract System.Byte[] Write3Data
        {
            get;
            set;
        }
        public abstract System.Byte[] Write4Data
        {
            get;
            set;
        }
        public abstract System.Byte[] Write5Data
        {
            get;
            set;
        }
        public abstract System.Byte[] Write6Data
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
        public virtual void ClearInputProperties()
        {
        }
        public virtual void ClearOutput()
        {
        }
        public virtual void BeginInsertion(System.Int32 timeout)
        {
        }
        public virtual void BeginRemoval(System.Int32 timeout)
        {
        }
        public virtual void CleanCard()
        {
        }
        public virtual void ClearPrintWrite(Microsoft.PointOfService.PointCardAreas kind, System.Int32 horizontalPosition, System.Int32 verticalPosition, System.Int32 width, System.Int32 height)
        {
        }
        public virtual void PrintWrite(Microsoft.PointOfService.PointCardAreas kind, System.Int32 horizontalPosition, System.Int32 verticalPosition, System.String data)
        {
        }
        public virtual void RotatePrint(Microsoft.PointOfService.Rotation rotation)
        {
        }
        public virtual void ValidateData(System.String data)
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
