namespace Microsoft.PointOfService
{
    public abstract class SmartCardRW : Microsoft.PointOfService.PosCommon
    {
        protected SmartCardRW()
        {
        }
        public const System.Int32 StatusNoCard = 1;
        public const System.Int32 StatusCardPresent = 2;
        public const System.Int32 ExtendedErrorRead = 201;
        public const System.Int32 ExtendedErrorWrite = 202;
        public const System.Int32 ExtendedErrorTorn = 203;
        public const System.Int32 ExtendedErrorNoCard = 204;
        public abstract System.Int32 DataCount { get; }
        public abstract System.Boolean DataEventEnabled { get; set;  }
        public abstract System.Int32 OutputId { get; }
        public abstract System.Boolean CapCardErrorDetection { get; }
        public abstract Microsoft.PointOfService.SmartCardInterfaceModes CapInterfaceMode { get; }
        public abstract Microsoft.PointOfService.SmartCardIsoEmvModes CapIsoEmvMode { get; }
        public abstract System.Int32 CapSCPresentSensor { get; }
        public abstract System.Int32 CapSCSlots { get; }
        public abstract Microsoft.PointOfService.SmartCardTransmissionProtocols CapTransmissionProtocol { get; }
        public abstract Microsoft.PointOfService.SmartCardInterfaceModes InterfaceMode { get; set;  }
        public abstract Microsoft.PointOfService.SmartCardIsoEmvModes IsoEmvMode { get; set;  }
        public abstract System.Int32 SCPresentSensor { get; }
        public abstract System.Int32 SCSlot { get; set;  }
        public abstract System.Boolean TransactionInProgress { get; }
        public abstract Microsoft.PointOfService.SmartCardTransmissionProtocols TransmissionProtocol { get; }
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DataEventHandler DataEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.OutputCompleteEventHandler OutputCompleteEvent;
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
        
        public virtual void EndInsertion()
        {
        }
        
        public virtual void EndRemoval()
        {
        }
        
        public virtual System.Byte[] ReadData(Microsoft.PointOfService.SmartCardReadAction action, System.Byte[] data)
        {
            return null;
        }
        
        public virtual void WriteData(Microsoft.PointOfService.SmartCardWriteAction action, System.Byte[] data)
        {
        }
        
    }
}
