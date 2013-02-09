namespace Microsoft.PointOfService.BasicServiceObjects
{
    public abstract class BillAcceptorBasic : Microsoft.PointOfService.BillAcceptor, System.IDisposable
    {
        protected BillAcceptorBasic()
        {
        }
        public override Microsoft.PointOfService.PowerReporting CapPowerReporting { get { return Microsoft.PointOfService.PowerReporting.None; } }
        public override System.Boolean CapStatisticsReporting { get { return false; } }
        public override System.Boolean CapUpdateStatistics { get { return false; } }
        public override System.Boolean Claimed { get { return false; } }
        public override System.Boolean DeviceEnabled { get { return false; } set { } }
        public override System.Boolean FreezeEvents { get { return false; } set { } }
        public override Microsoft.PointOfService.PowerNotification PowerNotify { get { return Microsoft.PointOfService.PowerNotification.Disabled; } set { } }
        public override Microsoft.PointOfService.PowerState PowerState { get { return Microsoft.PointOfService.PowerState.Unknown; } }
        public override Microsoft.PointOfService.ControlState State { get { return Microsoft.PointOfService.ControlState.Closed; } }
        public override System.String ServiceObjectDescription { get { return null; } }
        public override System.Version ServiceObjectVersion { get { return null; } }
        public override System.String DeviceDescription { get { return null; } }
        public override System.String DeviceName { get { return null; } }
        public override System.Boolean CapCompareFirmwareVersion { get { return false; } }
        public override System.Boolean CapUpdateFirmware { get { return false; } }
        public override System.Int32 DataCount { get { return 0; } }
        public override System.Boolean DataEventEnabled { get { return false; } set { } }
        #pragma warning disable 67
        public override event Microsoft.PointOfService.DirectIOEventHandler DirectIOEvent;
        #pragma warning disable 67
        public override event Microsoft.PointOfService.StatusUpdateEventHandler StatusUpdateEvent;
        #pragma warning disable 67
        public override event Microsoft.PointOfService.DataEventHandler DataEvent;
        public override void Claim(System.Int32 timeout)
        {
        }
        
        public override void Close()
        {
        }
        
        public override void Release()
        {
        }
        
        public override void ResetStatistics()
        {
        }
        
        public override void ResetStatistics(Microsoft.PointOfService.StatisticCategories statistics)
        {
        }
        
        public override void ResetStatistics(System.String[] statistics)
        {
        }
        
        public override void ResetStatistic(System.String statistic)
        {
        }
        
        public override System.String RetrieveStatistics()
        {
            return null;
        }
        
        public override System.String RetrieveStatistics(Microsoft.PointOfService.StatisticCategories statistics)
        {
            return null;
        }
        
        public override System.String RetrieveStatistics(System.String[] statistics)
        {
            return null;
        }
        
        public override System.String RetrieveStatistic(System.String statistic)
        {
            return null;
        }
        
        public override void UpdateStatistic(System.String name, System.Object value)
        {
        }
        
        public override void UpdateStatistics(Microsoft.PointOfService.Statistic[] statistics)
        {
        }
        
        public override void UpdateStatistics(Microsoft.PointOfService.StatisticCategories statistics, System.Object value)
        {
        }
        
        public virtual void Dispose()
        {
        }
        
        public override void Open()
        {
        }
        
        public override void ClearInput()
        {
        }
        
    }
}
