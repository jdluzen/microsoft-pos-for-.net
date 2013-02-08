namespace Microsoft.PointOfService.BasicServiceObjects
{
    public class MsrBasic : Microsoft.PointOfService.Msr, System.IDisposable
    {
        protected MsrBasic()
        {
        }
        public Microsoft.PointOfService.PowerReporting CapPowerReporting
        {
            get { return Microsoft.PointOfService.PowerReporting.None; }
        }
        public System.Boolean CapStatisticsReporting
        {
            get { return false; }
        }
        public System.Boolean CapUpdateStatistics
        {
            get { return false; }
        }
        public System.Boolean Claimed
        {
            get { return false; }
        }
        public System.Boolean DeviceEnabled
        {
            get { return false; }
            set { }
        }
        public System.Boolean FreezeEvents
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.PowerNotification PowerNotify
        {
            get { return Microsoft.PointOfService.PowerNotification.Disabled; }
            set { }
        }
        public Microsoft.PointOfService.PowerState PowerState
        {
            get { return Microsoft.PointOfService.PowerState.Unknown; }
        }
        public Microsoft.PointOfService.ControlState State
        {
            get { return Microsoft.PointOfService.ControlState.Closed; }
        }
        public System.String ServiceObjectDescription
        {
            get { return null; }
        }
        public System.Version ServiceObjectVersion
        {
            get { return null; }
        }
        public System.String DeviceDescription
        {
            get { return null; }
        }
        public System.String DeviceName
        {
            get { return null; }
        }
        public System.Boolean CapCompareFirmwareVersion
        {
            get { return false; }
        }
        public System.Boolean CapUpdateFirmware
        {
            get { return false; }
        }
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
        }
        public System.Boolean AutoDisable
        {
            get { return false; }
            set { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DirectIOEventHandler DirectIOEvent;
        #pragma warning disable 67
        public event Microsoft.PointOfService.StatusUpdateEventHandler StatusUpdateEvent;
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent;
        #pragma warning disable 67
        public event Microsoft.PointOfService.DataEventHandler DataEvent;
        public override void Claim(System.Int32 param_timeout)
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
        public override void ResetStatistics(Microsoft.PointOfService.StatisticCategories param_statistics)
        {
        }
        public override void ResetStatistics(System.String[] param_statistics)
        {
        }
        public override void ResetStatistic(System.String param_statistic)
        {
        }
        public override System.String RetrieveStatistics()
        {
            return null;
        }
        public override System.String RetrieveStatistics(Microsoft.PointOfService.StatisticCategories param_statistics)
        {
            return null;
        }
        public override System.String RetrieveStatistics(System.String[] param_statistics)
        {
            return null;
        }
        public override System.String RetrieveStatistic(System.String param_statistic)
        {
            return null;
        }
        public override void UpdateStatistic(System.String param_name, System.Object param_value)
        {
        }
        public override void UpdateStatistics(Microsoft.PointOfService.Statistic[] param_statistics)
        {
        }
        public override void UpdateStatistics(Microsoft.PointOfService.StatisticCategories param_statistics, System.Object param_value)
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
