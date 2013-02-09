namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class DeviceStatistics : System.IDisposable
    {
        public DeviceStatistics(System.String deviceName, System.String devicePath, System.String deviceType)
        {
        }
        
        protected DeviceStatistics()
        {
        }
        public System.Boolean CapStatisticsReporting { get { return false; } set { } }
        public System.Boolean CapUpdateStatistics { get { return false; } set { } }
        public System.Int32 FlushInterval { get { return 0; } set { } }
        public void ResetStatistics()
        {
        }
        
        public void ResetStatistics(Microsoft.PointOfService.StatisticCategories statistics)
        {
        }
        
        public void ResetStatistics(System.String[] statistics)
        {
        }
        
        public void ResetStatistic(System.String statistic)
        {
        }
        
        public System.String RetrieveStatistics()
        {
            return null;
        }
        
        public System.String RetrieveStatistics(Microsoft.PointOfService.StatisticCategories statistics)
        {
            return null;
        }
        
        public System.String RetrieveStatistics(System.String[] statistics)
        {
            return null;
        }
        
        public System.String RetrieveStatistic(System.String statistic)
        {
            return null;
        }
        
        public void UpdateStatistic(System.String name, System.Object value)
        {
        }
        
        public void UpdateStatistics(Microsoft.PointOfService.Statistic[] statistics)
        {
        }
        
        public void UpdateStatistics(Microsoft.PointOfService.StatisticCategories statistics, System.Object value)
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
        
        public void SetStatisticValue(System.String name, System.Object value)
        {
        }
        
        public void IncrementStatistic(System.String name)
        {
        }
        
        public void IncrementStatistic(System.String name, System.Int32 increment)
        {
        }
        
        public System.String GetStatisticValue(System.String name)
        {
            return null;
        }
        
        public void CreateStatistic(System.String statisticName, System.Boolean resettable)
        {
        }
        
        public void CreateStatistic(System.String statisticName, System.Boolean resettable, System.String unitOfMeasure)
        {
        }
        
        public void SetStatisticHandlers(System.String statisticName, Microsoft.PointOfService.BaseServiceObjects.GetStatistic getStatistic, Microsoft.PointOfService.BaseServiceObjects.SetStatistic setStatistic)
        {
        }
        
        public virtual void Dispose()
        {
        }
        
    }
}
