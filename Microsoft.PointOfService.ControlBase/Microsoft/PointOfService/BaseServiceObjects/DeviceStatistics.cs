namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class DeviceStatistics : System.IDisposable
    {
        public DeviceStatistics(System.String param_deviceName, System.String param_devicePath, System.String param_deviceType)
        {
        }
        protected DeviceStatistics()
        {
        }
        public System.Boolean CapStatisticsReporting
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapUpdateStatistics
        {
            get { return false; }
            set { }
        }
        public System.Int32 FlushInterval
        {
            get { return 0; }
            set { }
        }
        public void ResetStatistics()
        {
        }
        public void ResetStatistics(Microsoft.PointOfService.StatisticCategories param_statistics)
        {
        }
        public void ResetStatistics(System.String[] param_statistics)
        {
        }
        public void ResetStatistic(System.String param_statistic)
        {
        }
        public System.String RetrieveStatistics()
        {
            return null;
        }
        public System.String RetrieveStatistics(Microsoft.PointOfService.StatisticCategories param_statistics)
        {
            return null;
        }
        public System.String RetrieveStatistics(System.String[] param_statistics)
        {
            return null;
        }
        public System.String RetrieveStatistic(System.String param_statistic)
        {
            return null;
        }
        public void UpdateStatistic(System.String param_name, System.Object param_value)
        {
        }
        public void UpdateStatistics(Microsoft.PointOfService.Statistic[] param_statistics)
        {
        }
        public void UpdateStatistics(Microsoft.PointOfService.StatisticCategories param_statistics, System.Object param_value)
        {
        }
        public void Close()
        {
        }
        public System.Boolean FlushStatistics()
        {
            return false;
        }
        public System.Boolean LoadStatistics()
        {
            return false;
        }
        public void SetStatisticValue(System.String param_name, System.Object param_value)
        {
        }
        public void IncrementStatistic(System.String param_name)
        {
        }
        public void IncrementStatistic(System.String param_name, System.Int32 param_increment)
        {
        }
        public System.String GetStatisticValue(System.String param_name)
        {
            return null;
        }
        public void CreateStatistic(System.String param_statisticName, System.Boolean param_resettable)
        {
        }
        public void CreateStatistic(System.String param_statisticName, System.Boolean param_resettable, System.String param_unitOfMeasure)
        {
        }
        public void SetStatisticHandlers(System.String param_statisticName, Microsoft.PointOfService.BaseServiceObjects.GetStatistic param_getStatistic, Microsoft.PointOfService.BaseServiceObjects.SetStatistic param_setStatistic)
        {
        }
        public virtual void Dispose()
        {
        }
    }
}
