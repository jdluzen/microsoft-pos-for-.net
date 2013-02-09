namespace Microsoft.PointOfService
{
    public abstract class BumpBar : Microsoft.PointOfService.PosCommon
    {
        protected BumpBar()
        {
        }
        public const System.Int32 DataEventKey = 1;
        public const System.String StatisticBumpCount = "BumpCount";
        public abstract System.Int32 DataCount { get; }
        public abstract System.Boolean DataEventEnabled { get; set;  }
        public abstract System.Int32 OutputId { get; }
        public abstract System.Boolean AsyncMode { get; set;  }
        public abstract System.Int32 AutoToneDuration { get; set;  }
        public abstract System.Int32 AutoToneFrequency { get; set;  }
        public abstract System.Int32 BumpBarDataCount { get; }
        public abstract System.Boolean CapTone { get; }
        public abstract Microsoft.PointOfService.DeviceUnits CurrentUnitId { get; set;  }
        public abstract System.String ErrorString { get; }
        public abstract Microsoft.PointOfService.DeviceUnits ErrorUnits { get; }
        public abstract System.String EventString { get; }
        public abstract Microsoft.PointOfService.DeviceUnits EventUnitId { get; }
        public abstract Microsoft.PointOfService.DeviceUnits EventUnits { get; }
        public abstract System.Int32 Keys { get; }
        public abstract System.Int32 Timeout { get; set;  }
        public abstract Microsoft.PointOfService.DeviceUnits UnitsOnline { get; }
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DataEventHandler DataEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.OutputCompleteEventHandler OutputCompleteEvent;
        public virtual void ClearInput()
        {
        }
        
        public virtual void ClearOutput()
        {
        }
        
        public virtual void BumpBarSound(Microsoft.PointOfService.DeviceUnits units, System.Int32 frequency, System.Int32 duration, System.Int32 numberOfCycles, System.Int32 interSoundWait)
        {
        }
        
        public virtual void SetKeyTranslation(Microsoft.PointOfService.DeviceUnits units, System.Int32 scanCode, System.Int32 logicalKey)
        {
        }
        
    }
}
