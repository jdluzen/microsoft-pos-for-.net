namespace Microsoft.PointOfService
{
    public abstract class PosCommon : Microsoft.PointOfService.PosDevice
    {
        protected PosCommon()
        {
        }
        public const System.Int32 WaitForever = -1;
        public const System.Int32 StatusPowerOnline = 2001;
        public const System.Int32 StatusPowerOff = 2002;
        public const System.Int32 StatusPowerOffline = 2003;
        public const System.Int32 StatusPowerOffOffline = 2004;
        public const System.Int32 ExtendedErrorStatistics = 280;
        public const System.String StatisticUnifiedPOSVersion = "UnifiedPOSVersion";
        public const System.String StatisticDeviceCategory = "DeviceCategory";
        public const System.String StatisticManufacturerName = "ManufacturerName";
        public const System.String StatisticModelName = "ModelName";
        public const System.String StatisticSerialNumber = "SerialNumber";
        public const System.String StatisticManufactureDate = "ManufactureDate";
        public const System.String StatisticMechanicalRevision = "MechanicalRevision";
        public const System.String StatisticFirmwareRevision = "FirmwareRevision";
        public const System.String StatisticInterface = "Interface";
        public const System.String StatisticInstallationDate = "InstallationDate";
        public const System.String StatisticHoursPoweredCount = "HoursPoweredCount";
        public const System.String StatisticCommunicationErrorCount = "CommunicationErrorCount";
        public const System.Int32 ExtendedErrorFirmwareBadFile = 281;
        public const System.Int32 StatusUpdateFirmwareProgress = 2100;
        public const System.Int32 StatusUpdateFirmwareComplete = 2200;
        public const System.Int32 StatusUpdateFirmwareCompleteDeviceNotRestored = 2205;
        public const System.Int32 StatusUpdateFirmwareFailedDeviceOk = 2201;
        public const System.Int32 StatusUpdateFirmwareFailedDeviceUnrecoverable = 2202;
        public const System.Int32 StatusUpdateFirmwareFailedDeviceNeedsFirmware = 2203;
        public const System.Int32 StatusUpdateFirmwareFailedDeviceUnknown = 2204;
        public const System.Int32 ExtendedErrorStatisticsDependency = 282;
        public abstract Microsoft.PointOfService.PowerReporting CapPowerReporting { get; }
        public abstract System.Boolean CapStatisticsReporting { get; }
        public abstract System.Boolean CapUpdateStatistics { get; }
        public abstract System.String CheckHealthText { get; }
        public abstract System.Boolean Claimed { get; }
        public abstract System.String DeviceDescription { get; }
        public abstract System.Boolean DeviceEnabled { get; set;  }
        public abstract System.String DeviceName { get; }
        public abstract System.Boolean FreezeEvents { get; set;  }
        public abstract Microsoft.PointOfService.PowerNotification PowerNotify { get; set;  }
        public abstract Microsoft.PointOfService.PowerState PowerState { get; }
        public abstract System.String ServiceObjectDescription { get; }
        public virtual System.Version ServiceObjectVersion { get { return null; } }
        public abstract Microsoft.PointOfService.ControlState State { get; }
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return null; } set { } }
        public virtual System.Boolean CapCompareFirmwareVersion { get { return false; } }
        public virtual System.Boolean CapUpdateFirmware { get { return false; } }
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DirectIOEventHandler DirectIOEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.StatusUpdateEventHandler StatusUpdateEvent;
        public virtual System.String CheckHealth(Microsoft.PointOfService.HealthCheckLevel level)
        {
            return null;
        }
        
        public virtual void Claim(System.Int32 timeout)
        {
        }
        
        public virtual void Close()
        {
        }
        
        public virtual void Open()
        {
        }
        
        public virtual Microsoft.PointOfService.DirectIOData DirectIO(System.Int32 command, System.Int32 data, System.Object obj)
        {
            return new Microsoft.PointOfService.DirectIOData();
        }
        
        public virtual void Release()
        {
        }
        
        public virtual void ResetStatistics()
        {
        }
        
        public virtual void ResetStatistics(Microsoft.PointOfService.StatisticCategories statistics)
        {
        }
        
        public virtual void ResetStatistics(System.String[] statistics)
        {
        }
        
        public virtual void ResetStatistic(System.String statistic)
        {
        }
        
        public virtual System.String RetrieveStatistics()
        {
            return null;
        }
        
        public virtual System.String RetrieveStatistics(Microsoft.PointOfService.StatisticCategories statistics)
        {
            return null;
        }
        
        public virtual System.String RetrieveStatistics(System.String[] statistics)
        {
            return null;
        }
        
        public virtual System.String RetrieveStatistic(System.String statistic)
        {
            return null;
        }
        
        public virtual void UpdateStatistic(System.String name, System.Object value)
        {
        }
        
        public virtual void UpdateStatistics(Microsoft.PointOfService.Statistic[] statistics)
        {
        }
        
        public virtual void UpdateStatistics(Microsoft.PointOfService.StatisticCategories statistics, System.Object value)
        {
        }
        
        public virtual Microsoft.PointOfService.CompareFirmwareResult CompareFirmwareVersion(System.String firmwareFileName)
        {
            return Microsoft.PointOfService.CompareFirmwareResult.Older;
        }
        
        public virtual void UpdateFirmware(System.String firmwareFileName)
        {
        }
        
    }
}
