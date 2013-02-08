namespace Microsoft.PointOfService
{
    public class SmartCardRW : Microsoft.PointOfService.PosCommon
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
        public System.Boolean CapCardErrorDetection
        {
            get { return false; }
        }
        public Microsoft.PointOfService.SmartCardInterfaceModes CapInterfaceMode
        {
            get { return Microsoft.PointOfService.SmartCardInterfaceModes.Transaction; }
        }
        public Microsoft.PointOfService.SmartCardIsoEmvModes CapIsoEmvMode
        {
            get { return Microsoft.PointOfService.SmartCardIsoEmvModes.Iso; }
        }
        public System.Int32 CapSCPresentSensor
        {
            get { return 0; }
        }
        public System.Int32 CapSCSlots
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.SmartCardTransmissionProtocols CapTransmissionProtocol
        {
            get { return Microsoft.PointOfService.SmartCardTransmissionProtocols.T0; }
        }
        public Microsoft.PointOfService.SmartCardInterfaceModes InterfaceMode
        {
            get { return Microsoft.PointOfService.SmartCardInterfaceModes.Transaction; }
            set { }
        }
        public Microsoft.PointOfService.SmartCardIsoEmvModes IsoEmvMode
        {
            get { return Microsoft.PointOfService.SmartCardIsoEmvModes.Iso; }
            set { }
        }
        public System.Int32 SCPresentSensor
        {
            get { return 0; }
        }
        public System.Int32 SCSlot
        {
            get { return 0; }
            set { }
        }
        public System.Boolean TransactionInProgress
        {
            get { return false; }
        }
        public Microsoft.PointOfService.SmartCardTransmissionProtocols TransmissionProtocol
        {
            get { return Microsoft.PointOfService.SmartCardTransmissionProtocols.T0; }
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
